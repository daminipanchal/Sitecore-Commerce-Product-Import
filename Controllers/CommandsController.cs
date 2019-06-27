// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandsController.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2019
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LX.Plugin.ImportSellableItems.Controllers
{
    using LX.Plugin.ImportSellableItems.Commands;
    using Microsoft.AspNetCore.Mvc;
    using Sitecore.Commerce.Core;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http.OData;

    /// <inheritdoc />
    /// <summary>
    /// Defines a controller
    /// </summary>
    /// <seealso cref="T:Sitecore.Commerce.Core.CommerceController" />
    public class CommandsController : CommerceController
    {
        public CommandsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {
        }
        [HttpPut]
        [Route("ImportSellableItems()")]
        public async Task<IActionResult> ImportSellableItems()
        {
            var command = this.Command<ImportSellableItemsCommand>();
            var result = await command.Process(this.CurrentContext);
            return new ObjectResult(command);
        }
    }
}