// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryEduLlmModelResponseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryEduLlmModelResponseResponseBodyResult Result { get; set; }
        public class QueryEduLlmModelResponseResponseBodyResult : TeaModel {
            [NameInMap("modelResult")]
            [Validation(Required=false)]
            public QueryEduLlmModelResponseResponseBodyResultModelResult ModelResult { get; set; }
            public class QueryEduLlmModelResponseResponseBodyResultModelResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><c>json\n{\n  \&quot;题目1\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目2\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目3\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目4\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;√\&quot;\n  },\n  \&quot;题目5\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;√\&quot;\n  },\n  \&quot;题目6\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  }\n}\n</c></para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public QueryEduLlmModelResponseResponseBodyResultModelResultUsage Usage { get; set; }
                public class QueryEduLlmModelResponseResponseBodyResultModelResultUsage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>888</para>
                    /// </summary>
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public int? InputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>666</para>
                    /// </summary>
                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public int? OutputTokens { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>requestxxxxxxx</para>
            /// </summary>
            [NameInMap("reqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
