// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddOrgTextEmotionResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddOrgTextEmotionResponseBodyResult Result { get; set; }
        public class AddOrgTextEmotionResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp_123456</para>
            /// </summary>
            [NameInMap("emotionId")]
            [Validation(Required=false)]
            public string EmotionId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
