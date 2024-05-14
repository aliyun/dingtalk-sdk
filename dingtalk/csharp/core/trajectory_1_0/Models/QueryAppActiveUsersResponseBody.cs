// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryAppActiveUsersResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryAppActiveUsersResponseBodyList> List { get; set; }
        public class QueryAppActiveUsersResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appTraceId")]
            [Validation(Required=false)]
            public string AppTraceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("latitude")]
            [Validation(Required=false)]
            public float? Latitude { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("longitude")]
            [Validation(Required=false)]
            public float? Longitude { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("reportTime")]
            [Validation(Required=false)]
            public long? ReportTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
