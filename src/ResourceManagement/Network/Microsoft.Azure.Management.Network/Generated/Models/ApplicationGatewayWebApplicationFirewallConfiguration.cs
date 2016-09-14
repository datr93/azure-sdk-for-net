// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Application gateway web application firewall configuration
    /// </summary>
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayWebApplicationFirewallConfiguration class.
        /// </summary>
        public ApplicationGatewayWebApplicationFirewallConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayWebApplicationFirewallConfiguration class.
        /// </summary>
        public ApplicationGatewayWebApplicationFirewallConfiguration(bool? enabled = default(bool?), string firewallMode = default(string))
        {
            Enabled = enabled;
            FirewallMode = firewallMode;
        }

        /// <summary>
        /// Whether web application firewall is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Web application firewall mode. Possible values include:
        /// 'Detection', 'Prevention'
        /// </summary>
        [JsonProperty(PropertyName = "firewallMode")]
        public string FirewallMode { get; set; }

    }
}
