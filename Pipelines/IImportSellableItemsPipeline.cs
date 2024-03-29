﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIMportSellableItemsPipelineArgument.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2019
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LX.Plugin.ImportSellableItems.Pipelines
{
    using LX.Plugin.ImportSellableItems.Pipelines.Arguments;
    using Sitecore.Commerce.Core;
    using Sitecore.Framework.Pipelines;

    /// <inheritdoc />
    /// <summary>
    /// The IIMportSellableItemsPipelineArgument.
    /// </summary>
    /// 

    [PipelineDisplayName(ImportSellableItemsConstants.Pipelines.ImportSellableItems)]
    public interface IIMportSellableItemsPipeline : IPipeline<ImportSellableItemPipelineArgument, string, CommercePipelineExecutionContext>
    {

    }
}