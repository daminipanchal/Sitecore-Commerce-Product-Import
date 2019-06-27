using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LX.Plugin.ImportSellableItems.Policies
{
    public class KnownStoresViewsPolicy : Policy
    {
        public KnownStoresViewsPolicy()
        {
            SellableItemImportDashboardName = "Import Products";
        }

        public string SellableItemImportDashboardName { get; set; }
    }
}
