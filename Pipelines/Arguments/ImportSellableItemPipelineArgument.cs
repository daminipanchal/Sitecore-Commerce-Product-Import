// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImportSellableItemPipelineArgumentArgument.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2019
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LX.Plugin.ImportSellableItems.Pipelines.Arguments
{
    using LX.Plugin.ImportSellableItems.Entities;
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Catalog;
    using Sitecore.Framework.Conditions;
    using System.Collections.Generic;


    /// <inheritdoc />
    /// <summary>
    /// The ImportSellableItemPipelineArgumentArgument.
    /// </summary>
    public class ImportSellableItemPipelineArgument : PipelineArgument
    {
        public ImportSellableItemPipelineArgument(string xmlfilepath)
        {
            Condition.Requires(xmlfilepath).IsNotNull("The xmlfilepath parameter can not be null");
            this.XMlFilePath = xmlfilepath;
        }
        public string XMlFilePath { get; set; }
        public bool IsXMlfileValidate { get; set; }
        public SellableItem SellableItem { get; set; }
        public Catalog Catalog { get; set; }
        public List<ProductSuperCategory> SuperCategoryList { get; set; }

    }

    public class ProductSuperCategory
    {
        public Category SuperCategory { get; set; }
        public List<ProductCategory> ProductCategoryList { get; set; }
    }
    public class ProductCategory
    {
        public Category Category { get; set; }
        public List<ProductSubCategory> ProductSubCategoryList { get; set; }

    }
    public class ProductSubCategory
    {
        public Category SubCategory { get; set; }
    }
}