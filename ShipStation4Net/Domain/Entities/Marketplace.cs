﻿#region License
/*
 * Copyright 2017 Brandon James
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
#endregion

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipStation4Net.Domain.Entities
{
    public class Marketplace
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("marketplaceId")]
        public int MarketplaceId { get; set; }

        [JsonProperty("canRefresh")]
        public bool CanRefresh { get; set; }

        [JsonProperty("supportsCustomMappings")]
        public bool SupportsCustomMappings { get; set; }

        [JsonProperty("supportsCustomStatuses")]
        public bool SupportsCustomStatuses { get; set; }

        [JsonProperty("canConfirmShipments")]
        public bool CanConfirmShipments { get; set; }
    }

}