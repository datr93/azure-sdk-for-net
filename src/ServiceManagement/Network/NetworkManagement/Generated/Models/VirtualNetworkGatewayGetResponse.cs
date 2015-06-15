// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class VirtualNetworkGatewayGetResponse : AzureOperationResponse
    {
        private GatewayDefaultSite _defaultSite;
        
        /// <summary>
        /// Optional. The default site on the gateway.
        /// </summary>
        public GatewayDefaultSite DefaultSite
        {
            get { return this._defaultSite; }
            set { this._defaultSite = value; }
        }
        
        private bool _enableBgp;
        
        /// <summary>
        /// Optional. EnableBgp flag
        /// </summary>
        public bool EnableBgp
        {
            get { return this._enableBgp; }
            set { this._enableBgp = value; }
        }
        
        private Guid _gatewayId;
        
        /// <summary>
        /// Optional. The local network Gateway Id
        /// </summary>
        public Guid GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }
        
        private string _gatewayName;
        
        /// <summary>
        /// Optional. The virtual network gateway Name.
        /// </summary>
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }
        
        private string _gatewaySKU;
        
        /// <summary>
        /// Optional. The SKU for this virtual network gateway.
        /// </summary>
        public string GatewaySKU
        {
            get { return this._gatewaySKU; }
            set { this._gatewaySKU = value; }
        }
        
        private string _gatewayType;
        
        /// <summary>
        /// Optional. The type of gateway routing used for this virtual network.
        /// </summary>
        public string GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }
        
        private GatewayEvent _lastEvent;
        
        /// <summary>
        /// Optional. The last recorded event for this virtual network gateway.
        /// </summary>
        public GatewayEvent LastEvent
        {
            get { return this._lastEvent; }
            set { this._lastEvent = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Location
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. The provisioning state of the virtual network gateway.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _subnetId;
        
        /// <summary>
        /// Optional. SubnetId
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }
        
        private string _vipAddress;
        
        /// <summary>
        /// Optional. The virtual IP address for this virtual network gateway.
        /// </summary>
        public string VipAddress
        {
            get { return this._vipAddress; }
            set { this._vipAddress = value; }
        }
        
        private string _vnetId;
        
        /// <summary>
        /// Optional. VnetId
        /// </summary>
        public string VnetId
        {
            get { return this._vnetId; }
            set { this._vnetId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayGetResponse
        /// class.
        /// </summary>
        public VirtualNetworkGatewayGetResponse()
        {
        }
    }
}
