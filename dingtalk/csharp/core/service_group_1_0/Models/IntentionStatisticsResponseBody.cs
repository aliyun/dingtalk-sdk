// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionStatisticsResponseBody : TeaModel {
        [NameInMap("intentionStatisticsRecords")]
        [Validation(Required=false)]
        public List<IntentionStatisticsResponseBodyIntentionStatisticsRecords> IntentionStatisticsRecords { get; set; }
        public class IntentionStatisticsResponseBodyIntentionStatisticsRecords : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            [NameInMap("lastCount")]
            [Validation(Required=false)]
            public long? LastCount { get; set; }

        }

        [NameInMap("intentionTrend")]
        [Validation(Required=false)]
        public List<IntentionStatisticsResponseBodyIntentionTrend> IntentionTrend { get; set; }
        public class IntentionStatisticsResponseBodyIntentionTrend : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

        }

    }

}
