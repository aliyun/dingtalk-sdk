// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CallMultimodalModelRequest : TeaModel {
        [NameInMap("chatMessageModelList")]
        [Validation(Required=false)]
        public List<CallMultimodalModelRequestChatMessageModelList> ChatMessageModelList { get; set; }
        public class CallMultimodalModelRequestChatMessageModelList : TeaModel {
            [NameInMap("contentList")]
            [Validation(Required=false)]
            public List<CallMultimodalModelRequestChatMessageModelListContentList> ContentList { get; set; }
            public class CallMultimodalModelRequestChatMessageModelListContentList : TeaModel {
                [NameInMap("imageModel")]
                [Validation(Required=false)]
                public CallMultimodalModelRequestChatMessageModelListContentListImageModel ImageModel { get; set; }
                public class CallMultimodalModelRequestChatMessageModelListContentListImageModel : TeaModel {
                    [NameInMap("detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding819xxxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("enableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.5-plus</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.cxxxx1.json">https://example.cxxxx1.json</a></para>
        /// </summary>
        [NameInMap("reqLlmModelParamUrl")]
        [Validation(Required=false)]
        public string ReqLlmModelParamUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;手写文字识别&quot;,&quot;schema&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[&quot;题目1&quot;,&quot;题目2&quot;],&quot;properties&quot;:{&quot;题目1&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;正确答案&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;请根据题目描述正确答案&quot;},&quot;学生手写回答&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN&quot;},&quot;学生回答评价&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;评价学生手写回答是否工整，请勿包含双引号&quot;}},&quot;required&quot;:[&quot;正确答案&quot;,&quot;学生手写回答&quot;,&quot;学生回答评价&quot;],&quot;additionalProperties&quot;:false},&quot;题目2&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;正确答案&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;请根据题目描述正确答案&quot;},&quot;学生手写回答&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN&quot;},&quot;学生回答评价&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;评价学生手写回答是否工整，请勿包含双引号&quot;}},&quot;required&quot;:[&quot;正确答案&quot;,&quot;学生手写回答&quot;,&quot;学生回答评价&quot;],&quot;additionalProperties&quot;:false}}}},&quot;additionalProperties&quot;:fals</para>
        /// </summary>
        [NameInMap("responseFormat")]
        [Validation(Required=false)]
        public string ResponseFormat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING_xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("taskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}
