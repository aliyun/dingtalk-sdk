// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("emotionStatisticsRecords")]
        [Validation(Required=false)]
        public List<EmotionStatisticsResponseBodyEmotionStatisticsRecords> EmotionStatisticsRecords { get; set; }
        public class EmotionStatisticsResponseBodyEmotionStatisticsRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("emotionScore")]
            [Validation(Required=false)]
            public double? EmotionScore { get; set; }

        }

    }

}
