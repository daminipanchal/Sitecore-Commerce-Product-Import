// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImportSellableItemsCommandCommand.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2019
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LX.Plugin.ImportSellableItems.Commands
{
    using LX.Plugin.ImportSellableItems.Pipelines;
    using LX.Plugin.ImportSellableItems.Pipelines.Arguments;
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Core.Commands;
    using Sitecore.Commerce.Plugin.Catalog;
    using System;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Defines the ImportSellableItemsCommandCommand command.
    /// </summary>
    public class ImportSellableItemsCommand : CommerceCommand
    {

        private readonly IIMportSellableItemsPipeline _pipeline;
        private readonly FindEntityCommand _findEntityCommand;
        private readonly GetCatalogCommand _getCatalogCommand;
        private readonly CreateCatalogCommand _createCatalogCommand;
        private readonly IPersistEntityPipeline _persistPipeline;

        public ImportSellableItemsCommand(IIMportSellableItemsPipeline pipeline, IServiceProvider serviceProvider, FindEntityCommand findEntityCommand, GetCatalogCommand getCatalogCommand, CreateCatalogCommand createCatalogCommand, IPersistEntityPipeline persistPipeline) : base(serviceProvider)
        {
            this._pipeline = pipeline;
            _findEntityCommand = findEntityCommand;
            _getCatalogCommand = getCatalogCommand;
            _createCatalogCommand = createCatalogCommand;
            _persistPipeline = persistPipeline;
        }

        /// <summary>
        /// The process of the command
        /// </summary>
        /// <param name="commerceContext">
        /// The commerce context
        /// </param>
        /// <param name="parameter">
        /// The parameter for the command
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<string> Process(CommerceContext commerceContext)
        {
            using (var activity = CommandActivity.Start(commerceContext, this))
            {
                string retVal = string.Empty;
                var context = commerceContext.GetPipelineContextOptions();
                ImportSellableItemPipelineArgument pArg = new ImportSellableItemPipelineArgument("ProductImport.xml");
                retVal = await this._pipeline.Run(pArg, context);
                return retVal;
            }
        }
    }
}