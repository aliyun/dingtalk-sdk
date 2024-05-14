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
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("flashmeetingKey")]
            [Validation(Required=false)]
            public string FlashmeetingKey { get; set; }

            [NameInMap("hasSummary")]
            [Validation(Required=false)]
            public bool? HasSummary { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("summaryDocKey")]
            [Validation(Required=false)]
            public string SummaryDocKey { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("topics")]
            [Validation(Required=false)]
            public List<GetShanhuiByCalendarResponseBodyResultTopics> Topics { get; set; }
            public class GetShanhuiByCalendarResponseBodyResultTopics : TeaModel {
                [NameInMap("docKey")]
                [Validation(Required=false)]
                public string DocKey { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
