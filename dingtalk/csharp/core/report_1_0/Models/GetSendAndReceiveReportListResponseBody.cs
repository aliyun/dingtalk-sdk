// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class GetSendAndReceiveReportListResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<GetSendAndReceiveReportListResponseBodyDataList> DataList { get; set; }
        public class GetSendAndReceiveReportListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1507564800000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1507564800000</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>日报</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
