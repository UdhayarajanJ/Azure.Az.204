// <copyright file="ExperimentController.cs" company="Learn-AZ-204">
// Copyright (c) Learn-AZ-204. All rights reserved.
// </copyright>

namespace AzureContainers.Learn.Controllers
{
    using AzureContainers.Learn.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// For experiment controller api.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ExperimentController : ControllerBase
    {
        /// <summary>
        /// Simple message display the action and in the api route.
        /// </summary>
        /// <returns>Return simple sample object <see cref="ResponseObject"/>.</returns>
        [HttpGet]
        [Route(nameof(this.GetSomeMessageFromAPI))]
        public IActionResult GetSomeMessageFromAPI()
        {
            ResponseObject responseObject = new ResponseObject()
            {
                Result = true,
                Message = "Azure container learning goes well",
                StatusCode = StatusCodes.Status200OK,
            };
            return this.Ok(responseObject);
        }
    }
}
