// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryFlashMinutesSummaryResponseBody : TeaModel {
        [NameInMap("flashMinutesSummary")]
        [Validation(Required=false)]
        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary FlashMinutesSummary { get; set; }
        public class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public List<QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary> Summary { get; set; }
            public class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("headline")]
                [Validation(Required=false)]
                public string Headline { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

        }

    }

}
