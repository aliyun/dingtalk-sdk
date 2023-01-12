// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddOrgTextEmotionResponseBody : TeaModel {
        /// <summary>
        /// 添加企业文字表情结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddOrgTextEmotionResponseBodyResult Result { get; set; }
        public class AddOrgTextEmotionResponseBodyResult : TeaModel {
            /// <summary>
            /// 表情Id，用于唯一标识每个企业文字表情
            /// </summary>
            [NameInMap("emotionId")]
            [Validation(Required=false)]
            public string EmotionId { get; set; }

        }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
