// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryCollectingTraceTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCollectingTraceTaskResponseBodyList> List { get; set; }
        public class QueryCollectingTraceTaskResponseBodyList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ffsfsdf</para>
            /// </summary>
            [NameInMap("appTraceId")]
            [Validation(Required=false)]
            public string AppTraceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("geoCollectPeriod")]
            [Validation(Required=false)]
            public long? GeoCollectPeriod { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("geoReportPeriod")]
            [Validation(Required=false)]
            public long? GeoReportPeriod { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("geoReportStatus")]
            [Validation(Required=false)]
            public long? GeoReportStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("reportEndTime")]
            [Validation(Required=false)]
            public long? ReportEndTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("reportStartTime")]
            [Validation(Required=false)]
            public long? ReportStartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I01231231ads1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
