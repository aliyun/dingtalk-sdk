// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class SendMessageTipRequest : TeaModel {
        [NameInMap("defaultView")]
        [Validation(Required=false)]
        public SendMessageTipRequestDefaultView DefaultView { get; set; }
        public class SendMessageTipRequestDefaultView : TeaModel {
            [NameInMap("actionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("actionUrl")]
            [Validation(Required=false)]
            public string ActionUrl { get; set; }

            [NameInMap("authCode")]
            [Validation(Required=false)]
            public string AuthCode { get; set; }

            [NameInMap("authMediaId")]
            [Validation(Required=false)]
            public string AuthMediaId { get; set; }

            [NameInMap("cardTitle")]
            [Validation(Required=false)]
            public string CardTitle { get; set; }

            [NameInMap("cardTitleColor")]
            [Validation(Required=false)]
            public string CardTitleColor { get; set; }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("needShowUpdateTail")]
            [Validation(Required=false)]
            public string NeedShowUpdateTail { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("privateFieldMap")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateFieldMapValue> PrivateFieldMap { get; set; }

        [NameInMap("publicField")]
        [Validation(Required=false)]
        public SendMessageTipRequestPublicField PublicField { get; set; }
        public class SendMessageTipRequestPublicField : TeaModel {
            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            [NameInMap("durationDesc")]
            [Validation(Required=false)]
            public string DurationDesc { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("isExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            [NameInMap("readActionUrl")]
            [Validation(Required=false)]
            public string ReadActionUrl { get; set; }

            [NameInMap("readProgressDesc")]
            [Validation(Required=false)]
            public string ReadProgressDesc { get; set; }

        }

        [NameInMap("receiverUserId")]
        [Validation(Required=false)]
        public List<string> ReceiverUserId { get; set; }

        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
