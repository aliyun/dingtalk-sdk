// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendAgentOTOMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendAgentOTOMessageRequestDetail Detail { get; set; }
        public class SendAgentOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendAgentOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendAgentOTOMessageRequestDetailMessageBody : TeaModel {
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></para>
                        /// </summary>
                        [NameInMap("actionUrl")]
                        [Validation(Required=false)]
                        public string ActionUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>查看详情</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("buttonOrientation")]
                    [Validation(Required=false)]
                    public string ButtonOrientation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><b>提示信息</b></para>
                    /// </summary>
                    [NameInMap("markdown")]
                    [Validation(Required=false)]
                    public string Markdown { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>查看详情</para>
                    /// </summary>
                    [NameInMap("singleTitle")]
                    [Validation(Required=false)]
                    public string SingleTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://www.yourdomain.com">https://www.yourdomain.com</a></para>
                    /// </summary>
                    [NameInMap("singleUrl")]
                    [Validation(Required=false)]
                    public string SingleUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>欢迎使用</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("image")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyImage Image { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyImage : TeaModel {
                    [NameInMap("mediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                }

                [NameInMap("interactiveMessage")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage InteractiveMessage { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage : TeaModel {
                    [NameInMap("callbackUrl")]
                    [Validation(Required=false)]
                    public string CallbackUrl { get; set; }

                    [NameInMap("cardBizId")]
                    [Validation(Required=false)]
                    public string CardBizId { get; set; }

                    [NameInMap("cardData")]
                    [Validation(Required=false)]
                    public string CardData { get; set; }

                    [NameInMap("cardTemplateId")]
                    [Validation(Required=false)]
                    public string CardTemplateId { get; set; }

                }

                [NameInMap("link")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyLink : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://www.yourdomain.com">https://www.yourdomain.com</a></para>
                    /// </summary>
                    [NameInMap("messageUrl")]
                    [Validation(Required=false)]
                    public string MessageUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>@1234-456</para>
                    /// </summary>
                    [NameInMap("picUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>欢迎使用</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>点击查看</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>欢迎使用。</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>欢迎使用。</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyText : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你好，欢迎使用服务窗。</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sid002b6dbb4f963e93e0</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user0001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234-5678-000</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
