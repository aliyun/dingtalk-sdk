// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryCollectingTraceTaskResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCollectingTraceTaskResponseBodyList> List { get; set; }
        public class QueryCollectingTraceTaskResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appTraceId")]
            [Validation(Required=false)]
            public string AppTraceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("geoCollectPeriod")]
            [Validation(Required=false)]
            public long? GeoCollectPeriod { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("geoReportPeriod")]
            [Validation(Required=false)]
            public long? GeoReportPeriod { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("geoReportStatus")]
            [Validation(Required=false)]
            public long? GeoReportStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("reportEndTime")]
            [Validation(Required=false)]
            public long? ReportEndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("reportStartTime")]
            [Validation(Required=false)]
            public long? ReportStartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
