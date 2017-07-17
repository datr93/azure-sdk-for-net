// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Status information about a virtual machine.
    /// </summary>
    public partial class ComputeVmInstanceViewStatus
    {
        /// <summary>
        /// Initializes a new instance of the ComputeVmInstanceViewStatus
        /// class.
        /// </summary>
        public ComputeVmInstanceViewStatus() { }

        /// <summary>
        /// Initializes a new instance of the ComputeVmInstanceViewStatus
        /// class.
        /// </summary>
        public ComputeVmInstanceViewStatus(string code = default(string), string displayStatus = default(string), string message = default(string))
        {
            Code = code;
            DisplayStatus = displayStatus;
            Message = message;
        }

        /// <summary>
        /// Gets the status Code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets the short localizable label for the status.
        /// </summary>
        [JsonProperty(PropertyName = "displayStatus")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// Gets the message associated with the status.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}