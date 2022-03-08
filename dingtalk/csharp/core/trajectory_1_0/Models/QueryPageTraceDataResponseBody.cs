// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryPageTraceDataResponseBody : TeaModel {
        /// <summary>
        /// 是否结束
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 轨迹点列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryPageTraceDataResponseBodyList> List { get; set; }
        public class QueryPageTraceDataResponseBodyList : TeaModel {
            /// <summary>
            /// 经纬度
            /// </summary>
            [NameInMap("coordinates")]
            [Validation(Required=false)]
            public QueryPageTraceDataResponseBodyListCoordinates Coordinates { get; set; }
            public class QueryPageTraceDataResponseBodyListCoordinates : TeaModel {
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public float? Latitude { get; set; }
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public float? Longitude { get; set; }
            };

            /// <summary>
            /// 定位时间
            /// </summary>
            [NameInMap("gmtLocation")]
            [Validation(Required=false)]
            public long? GmtLocation { get; set; }

            /// <summary>
            /// 上报时间
            /// </summary>
            [NameInMap("gmtUpload")]
            [Validation(Required=false)]
            public long? GmtUpload { get; set; }

        }

        /// <summary>
        /// 下一个开始位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
