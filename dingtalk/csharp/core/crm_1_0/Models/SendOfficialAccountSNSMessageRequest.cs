// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SendOfficialAccountSNSMessageRequest : TeaModel {
        [NameInMap("bindingToken")]
        [Validation(Required=false)]
        public string BindingToken { get; set; }

        /// <summary>
        /// API调用标识，可选参数
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 消息详情
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendOfficialAccountSNSMessageRequestDetail Detail { get; set; }
        public class SendOfficialAccountSNSMessageRequestDetail : TeaModel {
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendOfficialAccountSNSMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendOfficialAccountSNSMessageRequestDetailMessageBody : TeaModel {
                /// <summary>
                /// 卡片消息
                /// </summary>
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        public string Title { get; set; }
                        public string ActionUrl { get; set; }
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
                };

                /// <summary>
                /// 链接消息类型
                /// </summary>
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
                };

                /// <summary>
                /// markdown消息，仅对消息类型为markdown时有效
                /// </summary>
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
                };

                /// <summary>
                /// 文本消息体  对于文本类型消息时必填
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public SendOfficialAccountSNSMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendOfficialAccountSNSMessageRequestDetailMessageBodyText : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }
                };

            }
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
        };

        [NameInMap("dingClientId")]
        [Validation(Required=false)]
        public string DingClientId { get; set; }

        [NameInMap("dingOpenAppOrgId")]
        [Validation(Required=false)]
        public long? DingOpenAppOrgId { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        [NameInMap("dingUid")]
        [Validation(Required=false)]
        public long? DingUid { get; set; }

    }

}
