// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result of the GetSupportedOptimizationTypes API
    /// </summary>
    public partial class SupportedOptimizationTypesListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SupportedOptimizationTypesListResultInner class.
        /// </summary>
        public SupportedOptimizationTypesListResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SupportedOptimizationTypesListResultInner class.
        /// </summary>
        /// <param name="supportedOptimizationTypes">Supported optimization
        /// types for a profile.</param>
        public SupportedOptimizationTypesListResultInner(IList<string> supportedOptimizationTypes = default(IList<string>))
        {
            SupportedOptimizationTypes = supportedOptimizationTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets supported optimization types for a profile.
        /// </summary>
        [JsonProperty(PropertyName = "supportedOptimizationTypes")]
        public IList<string> SupportedOptimizationTypes { get; private set; }

    }
}
