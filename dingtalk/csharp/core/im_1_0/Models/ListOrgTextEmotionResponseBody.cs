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
                /// <summary>
                /// <b>Example:</b>
                /// <para>@234xxx</para>
                /// </summary>
                [NameInMap("backgroundMediaId")]
                [Validation(Required=false)]
                public string BackgroundMediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>@123xxx</para>
                /// </summary>
                [NameInMap("backgroundMediaIdForPanel")]
                [Validation(Required=false)]
                public string BackgroundMediaIdForPanel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>corp_131xxx</para>
                /// </summary>
                [NameInMap("emotionId")]
                [Validation(Required=false)]
                public string EmotionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>企业表情1</para>
                /// </summary>
                [NameInMap("emotionName")]
                [Validation(Required=false)]
                public string EmotionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
