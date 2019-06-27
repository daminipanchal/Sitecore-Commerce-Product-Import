

namespace LX.Plugin.ImportSellableItems.Pipelines.Blocks
{
    using LX.Plugin.ImportSellableItems.Pipelines.Arguments;
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Catalog;
    using Sitecore.Framework.Conditions;
    using Sitecore.Framework.Pipelines;
    using System.Threading.Tasks;
    using LX.Plugin.ImportSellableItems.Entities;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;
    using LX.Plugin.ImportSellableItems.Models;
    using Sitecore.Commerce.Core.Commands;

    [PipelineDisplayName(ImportSellableItemsConstants.Pipelines.Blocks.SellableItemManager)]
    public class SellableItemManager : PipelineBlock<ImportSellableItemPipelineArgument, string, CommercePipelineExecutionContext>
    {
        /// <summary>
        /// Gets or sets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        protected CommerceCommander commander { get; set; }
        private readonly FindEntityCommand _findEntityCommand;
        private readonly CreateSellableItemCommand _createSellableItemCommand;
        private readonly IFindEntityPipeline _findEntityPipeline;
        private readonly IDoesEntityExistPipeline _doesEntityExistPipeline;
        private readonly ICreateSellableItemPipeline _createSellableItemPipeline;
        private readonly EditSellableItemPipeline _editSellableItemPipeline;
        private readonly AssociateSellableItemToParentCommand _associateSellableItemToParentCommand;
        private readonly CreateCategoryCommand _createCategoryCommand;

        public SellableItemManager(CommerceCommander commander, IFindEntityPipeline findEntityPipeline, IDoesEntityExistPipeline doesEntityExistPipeline, CreateCategoryCommand createCategoryCommand, ICreateSellableItemPipeline createSellableItemPipeline, EditSellableItemPipeline editSellableItemPipeline, AssociateSellableItemToParentCommand associateSellableItemToParentCommand, FindEntityCommand findEntityCommand, CreateSellableItemCommand createSellableItemCommand)
            : base(null)
        {
            this.commander = commander;
            this._findEntityPipeline = findEntityPipeline;
            this._createCategoryCommand = createCategoryCommand;
            this._doesEntityExistPipeline = doesEntityExistPipeline;
            this._createSellableItemPipeline = createSellableItemPipeline;
            this._editSellableItemPipeline = editSellableItemPipeline;
            this._associateSellableItemToParentCommand = associateSellableItemToParentCommand;
            this._findEntityCommand = findEntityCommand;
            this._createSellableItemCommand = createSellableItemCommand;
        }


        public override async Task<string> Run(ImportSellableItemPipelineArgument arg, CommercePipelineExecutionContext context)
        {
            XDocument document = XDocument.Load(arg.XMlFilePath);
            var catalog = arg.Catalog;

            var selectedProducts = document.Descendants("Product").Where(r => r.Attribute("UserTypeID").Value == "Product");

            foreach (var productItem in selectedProducts)
            {
                if (productItem.HasElements)
                {
                    var attributes = from attribute in productItem.Descendants("Values") select attribute;

                    var feature_bullets_7 = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_7"))?.Value;
                    var feature_bullets_8 = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_8"))?.Value;
                    var feature_bullets_3 = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_3"))?.Value;
                    var copy = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Marketing_Copy"))?.Value;
                    var Feature_Bullets_6 = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_6"))?.Value;
                    var Certification_IAPMO = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Certification_IAPMO"))?.Value;
                    var Tub_Wattage = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Tub_Wattage"))?.Value;
                    //var Mfg_Product_Number_SAP = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Mfg_Product_Number_SAP"))?.Value;
                    //var Tub_Water_Depth = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Tub_Water_Depth"))?.Value;
                    //var Feature_Bullets_2 = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_2"))?.Value;
                    //var Batteries_Included_YN = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Batteries_Included_YN"))?.Value;

                    var variants = from variant in productItem.Descendants("Product").Where(r => (string)r.Attribute("UserTypeID").Value == "SKU") select variant;

                    string variantname = variants.ElementAt(0).Element("Name").Value;
                    string variantId = variants.ElementAt(0).Attribute("ID").Value;
                    string variantDName = variants.ElementAt(0).Element("Name").Value;

                    var variantAttributes = from attribute in variants.Descendants("Values") select attribute;

                    var feature_bullets_71 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_7"))?.Value;
                    var feature_bullets_81 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_8"))?.Value;
                    var feature_bullets_31 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_3"))?.Value;
                    var copy1 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Marketing_Copy"))?.Value;
                    var Feature_Bullets_61 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Feature_Bullets_6"))?.Value;
                    var Certification_IAPMO1 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Certification_IAPMO"))?.Value;
                    var Tub_Wattage1 = variantAttributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Tub_Wattage"))?.Value;


                    var product = new SellableItem
                    {
                        Components = new List<Component>
                                {
                                new CatalogsComponent
                                {
                                    ChildComponents = new List<Component>
                                    {
                                        new CatalogComponent
                                        {
                                            Name= catalog.Name,
                                            Id = catalog.Id,
                                        }
                                    }
                                },
                                new SellableItemStiboAttributesComponent
                                {
                                    Name = productItem.Element("Name").ToString(),
                                    Feature_Bullets_7 = feature_bullets_7,
                                    Feature_Bullets_8 = feature_bullets_8,
                                    Feature_Bullets_3 = feature_bullets_3,
                                    Marketing_Copy = copy,
                                    Feature_Bullets_6 = Feature_Bullets_6,
                                    Certification_UL = Certification_IAPMO,
                                    Tub_Wattage = Tub_Wattage,
                                    //Mfg_Product_Number_SAP = Mfg_Product_Number_SAP,
                                    //Tub_Water_Depth = Tub_Water_Depth,
                                    //Batteries_Included_YN = Batteries_Included_YN,
                                },

                                new ItemVariationsComponent
                                {
                                    ChildComponents = new List<Component>
                                     {
                                        new ItemVariationComponent
                                        {
                                            Id = variantId,
                                            Name = variantname,
                                            DisplayName = variantname,
                                        },
                                        new SellableItemStiboAttributesComponent
                                        {
                                            Feature_Bullets_7 = feature_bullets_71,
                                            Feature_Bullets_8 = feature_bullets_81,
                                            Feature_Bullets_3 = feature_bullets_31,
                                            Marketing_Copy = copy1,
                                            Feature_Bullets_6 = Feature_Bullets_61,
                                            Certification_UL = Certification_IAPMO1,
                                            Tub_Wattage = Tub_Wattage1,
                                            //Mfg_Product_Number_SAP = Mfg_Product_Number_SAP1,
                                            //Tub_Water_Depth = Tub_Water_Depth1,
                                            //Batteries_Included_YN = Batteries_Included_YN1,
                                        }
                                    }
                            },
                    },
                        Id = productItem.Attribute("ID").Value,
                        Name = productItem.Element("Name").Value,
                        DisplayName = productItem.Element("Name").Value,
                        Description = productItem.Element("Name").Value,
                        ProductId = productItem.Attribute("ID").Value,
                        Brand = attributes.Elements("Value").SingleOrDefault(r => r.Attribute("AttributeID").Value.Equals("Brand"))?.Value,
                    };

                    var categoryElement = productItem.Ancestors("Product").Where(r => r.Attribute("UserTypeID").Value == "Level3").FirstOrDefault();
                    string categoryName = categoryElement.Element("Name").Value;
                    var subCategoryItem = CreateOrGetCategory(context, arg.Catalog, categoryName, null);
                    var sellableItem = await CreateSellableItemByCommand(product, catalog, subCategoryItem.Result, context, catalog.Name);
                    arg.SellableItem = sellableItem;
                }
            }

            return "Commerce SellableItems Imported Successfully";
        }
        private async Task<Category> CreateOrGetCategory(CommercePipelineExecutionContext context, Catalog catalog, string categoryName, string parentCategoryId = null)
        {
            try
            {
                string categoryId = GenerateFullCategoryId(catalog.Name, categoryName);

                //Check if catalog with given name already exists before trying to create a new one
                Category category = await _findEntityCommand.Process(context.CommerceContext, typeof(Category),
                                                            categoryId, false) as Category;

                if (category == null)
                {
                    context.Logger.LogInformation($"ProductImport:Category Not Found, result is nill _getCategoryCommand:{categoryId}");
                    context.Logger.LogInformation($"ProductImport:Creating Category: {categoryId}");
                    category = await _createCategoryCommand.Process(context.CommerceContext, catalog.Id, categoryName, categoryName, categoryName) as Category;

                    category.ParentCatalogList = catalog.SitecoreId;
                }
                else
                {
                    context.Logger.LogInformation($"ProductImport: Category found  _findEntityPipeline, catalog: {categoryName}");
                }
                return category;
            }
            catch (Exception ex)
            {
                context.Logger.LogInformation($"ProductImport: Error during catelog process" + ex.Message);
                return null;
            }
        }

        private async Task<SellableItem> CreateSellableItemByCommand(SellableItem item, Catalog catalog, Category category, CommercePipelineExecutionContext context, string catalogName)
        {
            try
            {
                //Try to find given sellable item in Commerce database
                SellableItem sellableEntity = await _findEntityCommand.Process(context.CommerceContext, typeof(SellableItem), item.Id) as SellableItem;

                if (sellableEntity == null)
                {
                    //Create new Sellable Item, pass model properties as parameters
                    sellableEntity = await _createSellableItemCommand.Process(context.CommerceContext, item.Id, item.Name, item.DisplayName, item.Description);
                }
                else
                {
                    //Update Sellable Item properties
                    sellableEntity.Name = item.Name;
                    sellableEntity.DisplayName = item.DisplayName;
                    sellableEntity.Description = item.Description;
                    sellableEntity.Brand = item.Brand;
                    sellableEntity.Manufacturer = item.Manufacturer;
                    sellableEntity.TypeOfGood = item.TypeOfGood;
                    sellableEntity.Tags = item.Tags;

                    ////Save changes to Commerce database
                    //await commander.Pipeline<IPersistEntityPipeline>()
                    //    .Run(new PersistEntityArgument(sellableEntity), context.CommerceContext.GetPipelineContextOptions());
                }
                //foreach (var policy in item.Policies)
                //{
                //    if (sellableEntity.HasPolicy(policy.GetType()))
                //    {
                //        sellableEntity.RemovePolicy(policy.GetType());
                //    }
                //    sellableEntity.SetPolicy(policy);
                //}
                //sellableEntity.Brand = item.Brand;
                //sellableEntity.Manufacturer = item.Manufacturer;
                //sellableEntity.TypeOfGood = item.TypeOfGood;

                //if (sellableEntity.Components.Any())
                //{
                //    sellableEntity.Components.Clear();
                //}
                //var editResults = await _editSellableItemPipeline.Run(sellableEntity, context);
                //foreach (var comp in item.Components)
                //{
                //    if (sellableEntity.HasComponent(comp.GetType()))
                //    {
                //        sellableEntity.RemoveComponent(comp.GetType());
                //    }
                //    sellableEntity.SetComponent(comp);
                //}

                //await AssociateSellableItemToParent(sellableEntity, catalog, category, context);

                //Add the new sellable item to the category
                //var referenceArgument = await commander.Command<AssociateSellableItemToParentCommand>()
                //    .Process(context.CommerceContext, catalog.Id, category.Id, sellableEntity.Id);

                // Get updated sellableitem after association for latest version
                //sellableEntity = await commander.Command<FindEntityCommand>()
                //    .Process(context.CommerceContext, typeof(SellableItem), sellableEntity.Id) as SellableItem;


                ////Save changes to to existing Category into Commerce database
                //await commander.Pipeline<IPersistEntityPipeline>().Run(new PersistEntityArgument(sellableEntity), context.CommerceContext.GetPipelineContextOptions());

                return sellableEntity;
            }
            catch (Exception e)
            {
                context.Logger.LogInformation("ProductImport:Error While creating sellable Item" + e.Message);
            }
            return null;
        }
        private async Task AssociateSellableItemToParent(SellableItem sitem, Catalog catalog, Category category, CommercePipelineExecutionContext context)
        {
            var sItemId = sitem.Id;
            string catalogId = GenerateFullCatalogName(catalog.Name);
            string categoryId = GenerateFullCategoryId(catalog.Name, category.Name);
            var catalogReferenceArgument = await _associateSellableItemToParentCommand.Process(context.CommerceContext, catalogId, categoryId, sItemId);

            //Add the new sellable item to the category
            var referenceArgument = await commander.Command<AssociateSellableItemToParentCommand>()
                .Process(context.CommerceContext, catalog.Id, category.Id, sItemId);
        }

        private static string GenerateFullCatalogName(string catalogName)
        {
            return $"{CommerceEntity.IdPrefix<Catalog>()}{catalogName}";
        }
        private static string GenerateFullCategoryId(string catalogName, string categoryName)
        {
            return $"{CommerceEntity.IdPrefix<Category>()}{catalogName}-{categoryName}";
        }
    }
}