

namespace LX.Plugin.ImportSellableItems.Pipelines
{
    using LX.Plugin.ImportSellableItems.Pipelines.Arguments;
    using Microsoft.Extensions.Logging;
    using Sitecore.Commerce.Core;
    using Sitecore.Framework.Pipelines;


    public class IMportSellableItemsPipeline : CommercePipeline<ImportSellableItemPipelineArgument, string>, IIMportSellableItemsPipeline
    {
        public IMportSellableItemsPipeline(IPipelineConfiguration<IIMportSellableItemsPipeline> configuration, ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}

