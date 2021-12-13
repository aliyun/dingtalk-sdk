// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SendOfficialAccountOTOMessageRequest : TeaModel {
        /// <summary>
        /// 服务窗帐号ID
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

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
        public SendOfficialAccountOTOMessageRequestDetail Detail { get; set; }
        public class SendOfficialAccountOTOMessageRequestDetail : TeaModel {
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendOfficialAccountOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendOfficialAccountOTOMessageRequestDetailMessageBody : TeaModel {
                /// <summary>
                /// 卡片消息
                /// </summary>
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
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
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink : TeaModel {
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
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
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
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyText : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }
                };

            }
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
        };

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

    }

}
