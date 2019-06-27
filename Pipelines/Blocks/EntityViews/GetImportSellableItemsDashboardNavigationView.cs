using LX.Plugin.ImportSellableItems.Policies;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.EntityViews;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LX.Plugin.ImportSellableItems.Pipelines.Blocks.EntityViews
{
    [PipelineDisplayName(ImportSellableItemsConstants.Pipelines.Blocks.ImportSellableItemsDashboardNavigationView)]
    public class GetImportSellableItemsDashboardNavigationView : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
    {
        public override Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
        {
            Condition.Requires(entityView).IsNotNull($"{Name}: The argument cannot be null.");

            var dashboardName = context.GetPolicy<KnownStoresViewsPolicy>().SellableItemImportDashboardName;
            var importProductDashboardView = new EntityView()
            {
                Name = dashboardName,
                ItemId = dashboardName,
                Icon = ImportSellableItemsConstants.Icons.InboxInto,
                DisplayRank = 6
            };
            entityView.ChildViews.Add(importProductDashboardView);

            return Task.FromResult(entityView);
        }

        public GetImportSellableItemsDashboardNavigationView()
          : base(null)
        {
        }
    }
}
