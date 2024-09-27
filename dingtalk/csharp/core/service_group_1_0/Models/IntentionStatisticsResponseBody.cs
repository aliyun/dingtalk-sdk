// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("intentionStatisticsRecords")]
        [Validation(Required=false)]
        public List<IntentionStatisticsResponseBodyIntentionStatisticsRecords> IntentionStatisticsRecords { get; set; }
        public class IntentionStatisticsResponseBodyIntentionStatisticsRecords : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品异常类</para>
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("lastCount")]
            [Validation(Required=false)]
            public long? LastCount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("intentionTrend")]
        [Validation(Required=false)]
        public List<IntentionStatisticsResponseBodyIntentionTrend> IntentionTrend { get; set; }
        public class IntentionStatisticsResponseBodyIntentionTrend : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20220101</para>
            /// </summary>
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品异常类</para>
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

        }

    }

}
