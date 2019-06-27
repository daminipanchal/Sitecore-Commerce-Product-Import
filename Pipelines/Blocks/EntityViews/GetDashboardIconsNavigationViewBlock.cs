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
    public class GetDashboardIconsNavigationViewBlock : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
    {
        public override Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
        {
            Condition.Requires(entityView).IsNotNull($"{Name}: The argument cannot be null.");

            foreach (var icon in ImportSellableItemsConstants.IconList)
            {
                var iconDashboardView = new EntityView()
                {
                    Name = icon,
                    ItemId = icon,
                    Icon = icon,
                    DisplayRank = 10
                };
                entityView.ChildViews.Add(iconDashboardView);
            }

            return Task.FromResult(entityView);
        }

        public GetDashboardIconsNavigationViewBlock() : base(null)
        {
        }
    }
}
