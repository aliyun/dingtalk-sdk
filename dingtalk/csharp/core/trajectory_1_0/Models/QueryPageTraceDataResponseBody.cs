// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryPageTraceDataResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryPageTraceDataResponseBodyList> List { get; set; }
        public class QueryPageTraceDataResponseBodyList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("coordinates")]
            [Validation(Required=false)]
            public QueryPageTraceDataResponseBodyListCoordinates Coordinates { get; set; }
            public class QueryPageTraceDataResponseBodyListCoordinates : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public float? Latitude { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public float? Longitude { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtLocation")]
            [Validation(Required=false)]
            public long? GmtLocation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtUpload")]
            [Validation(Required=false)]
            public long? GmtUpload { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
