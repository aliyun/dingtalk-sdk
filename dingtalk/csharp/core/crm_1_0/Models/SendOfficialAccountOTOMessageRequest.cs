// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SendOfficialAccountOTOMessageRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendOfficialAccountOTOMessageRequestDetail Detail { get; set; }
        public class SendOfficialAccountOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendOfficialAccountOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendOfficialAccountOTOMessageRequestDetailMessageBody : TeaModel {
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("actionUrl")]
                        [Validation(Required=false)]
                        public string ActionUrl { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    [NameInMap("buttonOrientation")]
                    [Validation(Required=false)]
                    public string ButtonOrientation { get; set; }

                    [NameInMap("markdown")]
                    [Validation(Required=false)]
                    public string Markdown { get; set; }

                    [NameInMap("singleTitle")]
                    [Validation(Required=false)]
                    public string SingleTitle { get; set; }

                    [NameInMap("singleUrl")]
                    [Validation(Required=false)]
                    public string SingleUrl { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("image")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyImage Image { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyImage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>@lALPBbCc1XuaP_rNAljNAl</para>
                    /// </summary>
                    [NameInMap("mediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                }

                [NameInMap("link")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("messageUrl")]
                    [Validation(Required=false)]
                    public string MessageUrl { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("picUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyText : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
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

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
