// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ListOrgTextEmotionResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListOrgTextEmotionResponseBodyResult Result { get; set; }
        public class ListOrgTextEmotionResponseBodyResult : TeaModel {
            [NameInMap("emotions")]
            [Validation(Required=false)]
            public List<ListOrgTextEmotionResponseBodyResultEmotions> Emotions { get; set; }
            public class ListOrgTextEmotionResponseBodyResultEmotions : TeaModel {
                [NameInMap("backgroundMediaId")]
                [Validation(Required=false)]
                public string BackgroundMediaId { get; set; }

                [NameInMap("backgroundMediaIdForPanel")]
                [Validation(Required=false)]
                public string BackgroundMediaIdForPanel { get; set; }

                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("emotionId")]
                [Validation(Required=false)]
                public string EmotionId { get; set; }

                [NameInMap("emotionName")]
                [Validation(Required=false)]
                public string EmotionName { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
