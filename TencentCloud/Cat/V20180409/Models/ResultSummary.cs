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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResultSummary : AbstractModel
    {
        
        /// <summary>
        /// 统计时间
        /// </summary>
        [JsonProperty("LogTime")]
        public string LogTime{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 实时可用率
        /// </summary>
        [JsonProperty("AvailRatio")]
        public float? AvailRatio{ get; set; }

        /// <summary>
        /// 实时响应时间
        /// </summary>
        [JsonProperty("ReponseTime")]
        public float? ReponseTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogTime", this.LogTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "AvailRatio", this.AvailRatio);
            this.SetParamSimple(map, prefix + "ReponseTime", this.ReponseTime);
        }
    }
}

