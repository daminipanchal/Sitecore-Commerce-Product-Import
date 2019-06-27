// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigureSitecore.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2017
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LX.Plugin.ImportSellableItems
{
    using System.Reflection;
    using LX.Plugin.ImportSellableItems.Pipelines;
    using LX.Plugin.ImportSellableItems.Pipelines.Blocks;
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.Commerce.Core;
    using Sitecore.Framework.Configuration;
    using Sitecore.Framework.Pipelines.Definitions.Extensions;

    /// <summary>
    /// The configure sitecore class.
    /// </summary>
    public class ConfigureSitecore : IConfigureSitecore
    {
        /// <summary>
        /// The configure services.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.RegisterAllPipelineBlocks(assembly);
            services.Sitecore().Pipelines(config => config
              .AddPipeline<IIMportSellableItemsPipeline, IMportSellableItemsPipeline>(
                     configure =>
                     {
                         configure.Add<ValidateXMLFile>()
                         .Add<CatalogManager>()
                         .Add<CategoryManager>();
                         //.Add<SellableItemManager>();
                     })

                .ConfigurePipeline<IConfigureServiceApiPipeline>(configure => configure.Add<ConfigureServiceApiBlock>()));

            services.RegisterAllCommands(assembly);
        }
    }
}