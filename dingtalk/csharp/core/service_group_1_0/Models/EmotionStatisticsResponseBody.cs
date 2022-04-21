// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsResponseBody : TeaModel {
        /// <summary>
        /// 情感统计
        /// </summary>
        [NameInMap("emotionStatisticsRecords")]
        [Validation(Required=false)]
        public List<EmotionStatisticsResponseBodyEmotionStatisticsRecords> EmotionStatisticsRecords { get; set; }
        public class EmotionStatisticsResponseBodyEmotionStatisticsRecords : TeaModel {
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
            /// 负面情绪值（0-1,越大越负面)
            /// </summary>
            [NameInMap("emotionScore")]
            [Validation(Required=false)]
            public double? EmotionScore { get; set; }

        }

    }

}
