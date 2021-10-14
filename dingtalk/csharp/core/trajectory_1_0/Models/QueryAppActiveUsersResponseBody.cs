// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryAppActiveUsersResponseBody : TeaModel {
        /// <summary>
        /// 是否存在更多数据需要获取
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 数据集合
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryAppActiveUsersResponseBodyList> List { get; set; }
        public class QueryAppActiveUsersResponseBodyList : TeaModel {
            /// <summary>
            /// 轨迹采集开启时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 应用轨迹ID
            /// </summary>
            [NameInMap("appTraceId")]
            [Validation(Required=false)]
            public string AppTraceId { get; set; }

            /// <summary>
            /// 经度
            /// </summary>
            [NameInMap("longitude")]
            [Validation(Required=false)]
            public float? Longitude { get; set; }

            /// <summary>
            /// 纬度
            /// </summary>
            [NameInMap("latitude")]
            [Validation(Required=false)]
            public float? Latitude { get; set; }

            /// <summary>
            /// 该位置采集时间
            /// </summary>
            [NameInMap("reportTime")]
            [Validation(Required=false)]
            public long? ReportTime { get; set; }

            /// <summary>
            /// 员工Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 下一次获取开始位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
