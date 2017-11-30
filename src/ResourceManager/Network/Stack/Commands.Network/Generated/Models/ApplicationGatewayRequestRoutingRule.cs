// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
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
    /// Request routing rule of application gateway
    /// </summary>
    public partial class ApplicationGatewayRequestRoutingRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRule class.
        /// </summary>
        public ApplicationGatewayRequestRoutingRule() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRule class.
        /// </summary>
        public ApplicationGatewayRequestRoutingRule(string name = default(string), string etag = default(string), string ruleType = default(string), SubResource backendAddressPool = default(SubResource), SubResource backendHttpSettings = default(SubResource), SubResource httpListener = default(SubResource), SubResource urlPathMap = default(SubResource), string provisioningState = default(string))
        {
            Name = name;
            Etag = etag;
            RuleType = ruleType;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the rule type. Possible values for this property
        /// include: 'Basic', 'PathBasedRouting'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleType")]
        public string RuleType { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets http listener resource of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListener")]
        public SubResource HttpListener { get; set; }

        /// <summary>
        /// Gets or sets url path map resource of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMap")]
        public SubResource UrlPathMap { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the request routing rule
        /// resource Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
