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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPullStreamConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置id。
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 源Url。
        /// </summary>
        [JsonProperty("FromUrl")]
        public string FromUrl{ get; set; }

        /// <summary>
        /// 目的Url。
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// 区域id,1-深圳,2-上海，3-天津,4-香港。如有改动，需同时传入IspId。
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// 运营商id,1-电信,2-移动,3-联通,4-其他,AreaId为4的时候,IspId只能为其他。如有改动，需同时传入AreaId。
        /// </summary>
        [JsonProperty("IspId")]
        public long? IspId{ get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "FromUrl", this.FromUrl);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "IspId", this.IspId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

