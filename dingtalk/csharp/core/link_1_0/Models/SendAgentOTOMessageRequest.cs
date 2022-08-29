// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendAgentOTOMessageRequest : TeaModel {
        /// <summary>
        /// 消息详情
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendAgentOTOMessageRequestDetail Detail { get; set; }
        public class SendAgentOTOMessageRequestDetail : TeaModel {
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendAgentOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendAgentOTOMessageRequestDetailMessageBody : TeaModel {
                /// <summary>
                /// 卡片消息
                /// </summary>
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        public string ActionUrl { get; set; }
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
                };

                /// <summary>
                /// 链接消息类型
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyLink : TeaModel {
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
                public SendAgentOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
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
                public SendAgentOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyText : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }
                };

            }
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
        };

    }

}
