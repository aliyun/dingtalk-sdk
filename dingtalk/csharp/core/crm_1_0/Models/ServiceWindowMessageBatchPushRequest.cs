// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ServiceWindowMessageBatchPushRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("detail")]
        [Validation(Required=false)]
        public ServiceWindowMessageBatchPushRequestDetail Detail { get; set; }
        public class ServiceWindowMessageBatchPushRequestDetail : TeaModel {
            [NameInMap("bizRequestId")]
            [Validation(Required=false)]
            public string BizRequestId { get; set; }

            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public ServiceWindowMessageBatchPushRequestDetailMessageBody MessageBody { get; set; }
            public class ServiceWindowMessageBatchPushRequestDetailMessageBody : TeaModel {
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList : TeaModel {
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
                public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink Link { get; set; }
                public class ServiceWindowMessageBatchPushRequestDetailMessageBodyLink : TeaModel {
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
                public ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown : TeaModel {
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public ServiceWindowMessageBatchPushRequestDetailMessageBodyText Text { get; set; }
                public class ServiceWindowMessageBatchPushRequestDetailMessageBodyText : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

            }

            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            [NameInMap("sendToAll")]
            [Validation(Required=false)]
            public bool? SendToAll { get; set; }

            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
