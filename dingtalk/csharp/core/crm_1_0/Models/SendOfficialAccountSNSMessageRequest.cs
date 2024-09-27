// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SendOfficialAccountSNSMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bindingToken")]
        [Validation(Required=false)]
        public string BindingToken { get; set; }

        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendOfficialAccountSNSMessageRequestDetail Detail { get; set; }
        public class SendOfficialAccountSNSMessageRequestDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendOfficialAccountSNSMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendOfficialAccountSNSMessageRequestDetailMessageBody : TeaModel {
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        [NameInMap("actionUrl")]
                        [Validation(Required=false)]
                        public string ActionUrl { get; set; }

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

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("link")]
                [Validation(Required=false)]
                public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink Link { get; set; }
                public class SendOfficialAccountSNSMessageRequestDetailMessageBodyLink : TeaModel {
                    [NameInMap("messageUrl")]
                    [Validation(Required=false)]
                    public string MessageUrl { get; set; }

                    [NameInMap("picUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown : TeaModel {
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public SendOfficialAccountSNSMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendOfficialAccountSNSMessageRequestDetailMessageBodyText : TeaModel {
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
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
