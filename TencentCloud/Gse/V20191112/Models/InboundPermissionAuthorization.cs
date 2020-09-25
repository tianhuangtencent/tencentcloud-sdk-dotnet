/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InboundPermissionAuthorization : AbstractModel
    {
        
        /// <summary>
        /// 起始端口号
        /// </summary>
        [JsonProperty("FromPort")]
        public ulong? FromPort{ get; set; }

        /// <summary>
        /// IP 端范围，CIDR方式划分
        /// </summary>
        [JsonProperty("IpRange")]
        public string IpRange{ get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 终止端口号
        /// </summary>
        [JsonProperty("ToPort")]
        public ulong? ToPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromPort", this.FromPort);
            this.SetParamSimple(map, prefix + "IpRange", this.IpRange);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ToPort", this.ToPort);
        }
    }
}

