// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class QueryRemindResultsResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<QueryRemindResultsResponseBodyDataList> DataList { get; set; }
        public class QueryRemindResultsResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("endDateTime")]
            [Validation(Required=false)]
            public List<string> EndDateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18xxxx</para>
            /// </summary>
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("periodType")]
            [Validation(Required=false)]
            public int? PeriodType { get; set; }

            [NameInMap("remindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }

            [NameInMap("startDateTime")]
            [Validation(Required=false)]
            public List<string> StartDateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("toGroups")]
            [Validation(Required=false)]
            public List<QueryRemindResultsResponseBodyDataListToGroups> ToGroups { get; set; }
            public class QueryRemindResultsResponseBodyDataListToGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx群</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
