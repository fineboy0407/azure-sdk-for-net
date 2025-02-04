// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Result of testing one route. </summary>
    public partial class IotHubTestRouteResult
    {
        /// <summary> Initializes a new instance of IotHubTestRouteResult. </summary>
        internal IotHubTestRouteResult()
        {
        }

        /// <summary> Initializes a new instance of IotHubTestRouteResult. </summary>
        /// <param name="result"> Result of testing route. </param>
        /// <param name="details"> Detailed result of testing route. </param>
        internal IotHubTestRouteResult(IotHubTestResultStatus? result, IotHubTestRouteResultDetails details)
        {
            Result = result;
            Details = details;
        }

        /// <summary> Result of testing route. </summary>
        public IotHubTestResultStatus? Result { get; }
        /// <summary> Detailed result of testing route. </summary>
        internal IotHubTestRouteResultDetails Details { get; }
        /// <summary> JSON-serialized list of route compilation errors. </summary>
        public IReadOnlyList<RouteCompilationError> DetailsCompilationErrors
        {
            get => Details?.CompilationErrors;
        }
    }
}
