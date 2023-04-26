// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendAgentOTOMessageRequest : TeaModel {
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendAgentOTOMessageRequestDetail Detail { get; set; }
        public class SendAgentOTOMessageRequestDetail : TeaModel {
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
                public SendAgentOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public SendAgentOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendAgentOTOMessageRequestDetailMessageBodyText : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

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

        }

    }

}
