// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionStatisticsResponseBody : TeaModel {
        /// <summary>
        /// 意图统计
        /// </summary>
        [NameInMap("intentionStatisticsRecords")]
        [Validation(Required=false)]
        public List<IntentionStatisticsResponseBodyIntentionStatisticsRecords> IntentionStatisticsRecords { get; set; }
        public class IntentionStatisticsResponseBodyIntentionStatisticsRecords : TeaModel {
            /// <summary>
            /// 心声数量
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// 意图
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            /// <summary>
            /// 上期心声数量
            /// </summary>
            [NameInMap("lastCount")]
            [Validation(Required=false)]
            public long? LastCount { get; set; }

        }

        /// <summary>
        /// 意图趋势
        /// </summary>
        [NameInMap("intentionTrend")]
        [Validation(Required=false)]
        public List<IntentionStatisticsResponseBodyIntentionTrend> IntentionTrend { get; set; }
        public class IntentionStatisticsResponseBodyIntentionTrend : TeaModel {
            /// <summary>
            /// 心声数量
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// 日期
            /// </summary>
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            /// <summary>
            /// 意图
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

        }

    }

}
