// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CallMultimodalModelResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CallMultimodalModelResponseBodyResult Result { get; set; }
        public class CallMultimodalModelResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><c>json\n{\n  \&quot;题目1\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目2\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  }\n}\n</c></para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>requestxxxxxxx</para>
            /// </summary>
            [NameInMap("reqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public CallMultimodalModelResponseBodyResultUsage Usage { get; set; }
            public class CallMultimodalModelResponseBodyResultUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
