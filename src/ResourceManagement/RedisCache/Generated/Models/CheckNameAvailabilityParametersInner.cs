// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters body to pass for  name availability check.
    /// </summary>
    public partial class CheckNameAvailabilityParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckNameAvailabilityParametersInner class.
        /// </summary>
        public CheckNameAvailabilityParametersInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckNameAvailabilityParametersInner class.
        /// </summary>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public CheckNameAvailabilityParametersInner(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
