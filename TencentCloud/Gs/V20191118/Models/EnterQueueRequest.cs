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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnterQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// true：第一次请求排队 false：已在排队中，查询当前排名
        /// </summary>
        [JsonProperty("First")]
        public bool? First{ get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 资源池编号
        /// </summary>
        [JsonProperty("SetNumber")]
        public ulong? SetNumber{ get; set; }

        /// <summary>
        /// 游戏用户IP，用于就近调度，例如125.127.178.228
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "First", this.First);
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "SetNumber", this.SetNumber);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
        }
    }
}

