// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmeeting_1_0.Models
{
    public class GetShanhuiByCalendarResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetShanhuiByCalendarResponseBodyResult Result { get; set; }
        public class GetShanhuiByCalendarResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1685332800000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8K4ny9P9No06sjhk</para>
            /// </summary>
            [NameInMap("flashmeetingKey")]
            [Validation(Required=false)]
            public string FlashmeetingKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasSummary")]
            [Validation(Required=false)]
            public bool? HasSummary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1685318400000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2Hj32Uio28fjmMiu9Klsk</para>
            /// </summary>
            [NameInMap("summaryDocKey")]
            [Validation(Required=false)]
            public string SummaryDocKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试闪会</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("topics")]
            [Validation(Required=false)]
            public List<GetShanhuiByCalendarResponseBodyResultTopics> Topics { get; set; }
            public class GetShanhuiByCalendarResponseBodyResultTopics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>27Hio9BV23Ghj8LkRe34QzSdP94UtMkju</para>
                /// </summary>
                [NameInMap("docKey")]
                [Validation(Required=false)]
                public string DocKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>会议1</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
