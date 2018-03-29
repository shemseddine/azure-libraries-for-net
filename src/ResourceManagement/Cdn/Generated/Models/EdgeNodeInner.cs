// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EdgeNodeInner is a global Point of Presence (POP) location used to deliver
    /// CDN content to end users.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EdgeNodeInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the EdgeNodeInner class.
        /// </summary>
        public EdgeNodeInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdgeNodeInner class.
        /// </summary>
        /// <param name="ipAddressGroups">List of ip address groups.</param>
        public EdgeNodeInner(IList<IpAddressGroup> ipAddressGroups, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            IpAddressGroups = ipAddressGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of ip address groups.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddressGroups")]
        public IList<IpAddressGroup> IpAddressGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IpAddressGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpAddressGroups");
            }
        }
    }
}
