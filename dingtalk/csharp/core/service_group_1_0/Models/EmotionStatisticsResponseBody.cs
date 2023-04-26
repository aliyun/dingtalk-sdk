// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsResponseBody : TeaModel {
        [NameInMap("emotionStatisticsRecords")]
        [Validation(Required=false)]
        public List<EmotionStatisticsResponseBodyEmotionStatisticsRecords> EmotionStatisticsRecords { get; set; }
        public class EmotionStatisticsResponseBodyEmotionStatisticsRecords : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            [NameInMap("emotionScore")]
            [Validation(Required=false)]
            public double? EmotionScore { get; set; }

        }

    }

}
