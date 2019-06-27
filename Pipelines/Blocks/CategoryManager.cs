using LX.Plugin.ImportSellableItems.Pipelines.Arguments;
using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Commerce.Plugin.EntityVersions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LX.Plugin.ImportSellableItems.Pipelines.Blocks
{
    [PipelineDisplayName(ImportSellableItemsConstants.Pipelines.Blocks.CategoryManager)]
    public class CategoryManager : PipelineBlock<ImportSellableItemPipelineArgument, ImportSellableItemPipelineArgument, CommercePipelineExecutionContext>
    {
        private CommerceCommander _commander { get; set; }
        private readonly CreateCategoryCommand _createCategoryCommand;
        private readonly GetCategoryCommand _getCategoryCommand;
        private readonly AssociateCategoryToParentCommand _associateCategoryToParentCommand;
        private readonly FindEntityCommand _findEntityCommand;
        private readonly CreateRelationshipPipeline _createRelationshipPipeline;
        private readonly AddEntityVersionCommand _addEntityVersionCommand;

        public CategoryManager(CommerceCommander commander, GetCategoryCommand getCategoryCommand, CreateCategoryCommand createCategoryCommand, AssociateCategoryToParentCommand associateCategoryToParentCommand, FindEntityCommand findEntityCommand, CreateRelationshipPipeline createRelationshipPipeline, AddEntityVersionCommand addEntityVersionCommand)
        {
            this._commander = commander;
            this._getCategoryCommand = getCategoryCommand;
            this._createCategoryCommand = createCategoryCommand;
            this._associateCategoryToParentCommand = associateCategoryToParentCommand;
            this._findEntityCommand = findEntityCommand;
            this._createRelationshipPipeline = createRelationshipPipeline;
            this._addEntityVersionCommand = addEntityVersionCommand;
        }

        public override Task<ImportSellableItemPipelineArgument> Run(ImportSellableItemPipelineArgument arg, CommercePipelineExecutionContext context)
        {
            context.Logger.LogInformation("---------Start Process Category Structure Creation------------");
            return Task.Run(() =>
            {
                if (arg.IsXMlfileValidate && !string.IsNullOrWhiteSpace(arg.XMlFilePath) && arg.Catalog != null)
                {
                    context.Logger.LogInformation("---------Category Structure Created Successfully------------");
                    arg.SuperCategoryList = CreateCategoryStructure(arg, context);
                }
                else
                {
                    context.Logger.LogInformation("---------Error while validating argument during category structure creation------------");
                }
                return arg;
            });
        }

        private List<ProductSuperCategory> CreateCategoryStructure(ImportSellableItemPipelineArgument arg, CommercePipelineExecutionContext context)
        {
            XDocument document = XDocument.Load(arg.XMlFilePath);
            List<ProductSuperCategory> productSuperCategoryList = new List<ProductSuperCategory>();
            //Super Category Creation
            var selectedSuperCategories = document.Descendants("Product").Where(r => r.Attribute("UserTypeID").Value == "Level1");
            foreach (var superCategory in selectedSuperCategories)
            {
                string superCategoryName = superCategory.Element("Name").Value.ToString();
                ProductSuperCategory supercategory = new ProductSuperCategory();
                var superCategoryItem = CreateOrGetCategory(context, arg.Catalog, superCategoryName);
                if (superCategoryItem != null && superCategoryItem.Result != null)
                {
                    var tempCategory = superCategoryItem.Result;
                    //await AssociateCategory(context, arg.Catalog, tempCategory);
                    supercategory.SuperCategory = tempCategory;
                }

                List<ProductCategory> productCategoryList = new List<ProductCategory>();
                //Category Creation
                var selectedCategories = superCategory.Descendants("Product").Where(r => r.Attribute("UserTypeID").Value == "Level2");
                foreach (var category in selectedCategories)
                {
                    string categoryName = category.Element("Name").Value.ToString();
                    var categoryItem = CreateOrGetCategory(context, arg.Catalog, categoryName, superCategoryItem.Result.SitecoreId);
                    ProductCategory productCategory = new ProductCategory();
                    if (categoryItem != null && categoryItem.Result != null)
                    {
                        var tempCategory = categoryItem.Result;
                        //await AssociateCategory(context, arg.Catalog, tempCategory, superCategoryItem.Result.Id);
                        productCategory.Category = tempCategory;
                    }


                    List<ProductSubCategory> productSubCategoryList = new List<ProductSubCategory>();
                    //Sub Category Creation
                    var selectedSubCategories = category.Descendants("Product").Where(r => r.Attribute("UserTypeID").Value == "Level3");
                    foreach (var subCategory in selectedSubCategories)
                    {
                        string subCategoryName = subCategory.Element("Name").Value.ToString();
                        var subCategoryItem = CreateOrGetCategory(context, arg.Catalog, subCategoryName, categoryItem.Result.SitecoreId);
                        ProductSubCategory productSubCategory = new ProductSubCategory();
                        if (subCategoryItem != null && subCategoryItem.Result != null)
                        {
                            var tempCategory = subCategoryItem.Result;
                            //await AssociateCategory(context, arg.Catalog, tempCategory, subCategoryItem.Result.Id);
                            productSubCategory.SubCategory = tempCategory;
                        }
                        productSubCategoryList.Add(productSubCategory);
                    }
                    productCategory.ProductSubCategoryList = productSubCategoryList;
                    productCategoryList.Add(productCategory);
                }
                supercategory.ProductCategoryList = productCategoryList;
                productSuperCategoryList.Add(supercategory);
            }
            return productSuperCategoryList;
        }

        private async Task<Category> CreateOrGetCategory(CommercePipelineExecutionContext context, Catalog catalog, string categoryName, string parentCategoryId = null)
        {
            try
            {
                string categoryId = GenerateFullCategoryId(catalog.Name, categoryName);

                //Check if catalog with given name already exists before trying to create a new one
                Category category = await _findEntityCommand.Process(context.CommerceContext, typeof(Category), categoryId, false) as Category;

                if (category == null)
                {
                    context.Logger.LogInformation($"ProductImport:Category Not Found, result is nill _getCategoryCommand:{categoryId}");
                    context.Logger.LogInformation($"ProductImport:Creating Category: {categoryId}");
                    category = await _createCategoryCommand.Process(context.CommerceContext, catalog.Id, categoryName, categoryName, categoryName) as Category;

                    //category.ParentCatalogList = catalog.SitecoreId;

                    //int version = category.Version;
                    //if(category.Version != version + 1)

                    //var newItemVersion = category.EntityVersion + 1;
                    //await _addEntityVersionCommand.Process(context.CommerceContext, category, newItemVersion);

                    //Save Category Result
                    //var result = await _commander.Pipeline<IPersistEntityPipeline>()
                    //  .Run(new PersistEntityArgument(category), context.CommerceContext.GetPipelineContextOptions());


                    //if (string.IsNullOrWhiteSpace(parentCategoryId))
                    //    await _associateCategoryToParentCommand.Process(context.CommerceContext, catalog.Id, catalog.Id, category.Id);
                    //else
                    //    await _associateCategoryToParentCommand.Process(context.CommerceContext, catalog.Id, parentCategoryId, category.Id);


                    return category;
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

        private async Task AssociateCategory(CommercePipelineExecutionContext context, Catalog catalog, Category category, string parentCategoryId = null)
        {
            if (string.IsNullOrWhiteSpace(parentCategoryId))
            {
                await _createRelationshipPipeline.Run(
                    new RelationshipArgument(catalog.Id, category.Id, "CatalogToCategory")
                    {
                        Mode = new RelationshipMode?(RelationshipMode.Create)
                    }, context);
            }
            else
            {
                category.ParentCategoryList = parentCategoryId;
                await _createRelationshipPipeline.Run(
                    new RelationshipArgument(parentCategoryId, category.Id, "CategoryToCategory")
                    {
                        Mode = new RelationshipMode?(RelationshipMode.Create)
                    }, context);
            }
        }

        private static string GenerateFullCategoryId(string catalogName, string categoryName)
        {
            return $"{CommerceEntity.IdPrefix<Category>()}{catalogName}-{categoryName}";
        }

        private static string GenerateFullCatalogName(string catalogName)
        {
            return $"{CommerceEntity.IdPrefix<Catalog>()}{catalogName}";
        }
    }
}
