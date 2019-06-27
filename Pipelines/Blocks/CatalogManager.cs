using LX.Plugin.ImportSellableItems.Pipelines.Arguments;
using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LX.Plugin.ImportSellableItems.Pipelines.Blocks
{
    [PipelineDisplayName(ImportSellableItemsConstants.Pipelines.Blocks.CatalogManager)]
    public class CatalogManager : PipelineBlock<ImportSellableItemPipelineArgument, ImportSellableItemPipelineArgument, CommercePipelineExecutionContext>
    {

        private CommerceCommander _commander { get; set; }
        private readonly FindEntityCommand _findEntityCommand;
        private readonly CreateCatalogCommand _createCatalogCommand;
        private string catalogName = "Damini_Import";
        private string catalogDisplayName = "Damini Import";

        public CatalogManager(CommerceCommander commander, FindEntityCommand findEntityCommand, CreateCatalogCommand createCatalogCommand)
        {
            this._commander = commander;
            this._findEntityCommand = findEntityCommand;
            this._createCatalogCommand = createCatalogCommand;
        }

        public override Task<ImportSellableItemPipelineArgument> Run(ImportSellableItemPipelineArgument arg, CommercePipelineExecutionContext context)
        {
            context.Logger.LogInformation("---------Start Process Catalog Creation------------");
            return Task.Run(() =>
            {
                var catalog = GetOrCreateCatalog(catalogName, context);
                arg.Catalog = catalog.Result;
                context.Logger.LogInformation("---------Catalog Created Successfully------------");
                return arg;
            });
        }

        private async Task<Catalog> GetOrCreateCatalog(string catalogName, CommercePipelineExecutionContext context)
        {
            try
            {
                //Commerce would use a add different prefixes to internal IDs of different kinds of entities.
                //this will get us internal commerce ID for a given catalog name 
                var commerceCatalogId = $"{CommerceEntity.IdPrefix<Catalog>()}{catalogName}";

                //Check if catalog with given name already exists before trying to create a new one
                Catalog catalog = await _findEntityCommand.Process(context.CommerceContext, typeof(Catalog),
                                                            commerceCatalogId, false) as Catalog;
                if (catalog == null)
                {
                    var catalogBaseName = catalogName.Replace("_Catalog", string.Empty);

                    catalog = await _createCatalogCommand.Process(context.CommerceContext, catalogName, catalogDisplayName) as Catalog;

                    //Persist changes to Catalog (Price and Promo books associations created above) into Commerce database
                    var result = await _commander.Pipeline<IPersistEntityPipeline>()
                            .Run(new PersistEntityArgument(catalog), context.CommerceContext.GetPipelineContextOptions());

                    catalog = result.Entity as Catalog;
                }
                else
                {
                    context.Logger.LogInformation($"ProductImport: catalog found  _findEntityPipeline, catalog: {catalogName}");
                }
                if (catalog == null)
                {
                    context.Logger.LogInformation($"ProductImport: Error during catalog process");
                }
                return catalog;
            }
            catch (Exception ex)
            {
                context.Logger.LogInformation($"ProductImport: Error during catalog process" + ex.Message);
                return null;
            }
        }
    }
}
