// <copyright file="ResponseObject.cs" company="Learn-AZ-204">
// Copyright (c) Learn-AZ-204. All rights reserved.
// </copyright>

namespace AzureContainers.Learn.Models
{
    /// <summary>
    /// Response object which structured JSON response for client applications.
    /// </summary>
    public class ResponseObject
    {
        /// <summary>
        /// Gets or sets status code.
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets result of the actual types and data.
        /// </summary>
        public object Result { get; set; }
    }
}
