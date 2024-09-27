// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordVideoResponseBody : TeaModel {
        [NameInMap("videoList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordVideoResponseBodyVideoList> VideoList { get; set; }
        public class QueryCloudRecordVideoResponseBodyVideoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>59886</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631172094000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1127942</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>faa1566c5bc24f21821ae2394f82db2e</para>
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>290882268xxx1172033231</para>
            /// </summary>
            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("recordType")]
            [Validation(Required=false)]
            public long? RecordType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631172094000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WFBkgJvtxxxxtSaA1jK4sgiEiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
