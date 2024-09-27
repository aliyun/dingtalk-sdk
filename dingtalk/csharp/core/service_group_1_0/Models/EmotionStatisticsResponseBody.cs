// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("emotionStatisticsRecords")]
        [Validation(Required=false)]
        public List<EmotionStatisticsResponseBodyEmotionStatisticsRecords> EmotionStatisticsRecords { get; set; }
        public class EmotionStatisticsResponseBodyEmotionStatisticsRecords : TeaModel {
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
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("emotionScore")]
            [Validation(Required=false)]
            public double? EmotionScore { get; set; }

        }

    }

}
