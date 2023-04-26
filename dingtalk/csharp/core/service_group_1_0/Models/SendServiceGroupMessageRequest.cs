// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendServiceGroupMessageRequest : TeaModel {
        [NameInMap("atDingtalkIds")]
        [Validation(Required=false)]
        public List<string> AtDingtalkIds { get; set; }

        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        [NameInMap("btnOrientation")]
        [Validation(Required=false)]
        public string BtnOrientation { get; set; }

        [NameInMap("btns")]
        [Validation(Required=false)]
        public List<SendServiceGroupMessageRequestBtns> Btns { get; set; }
        public class SendServiceGroupMessageRequestBtns : TeaModel {
            [NameInMap("actionURL")]
            [Validation(Required=false)]
            public string ActionURL { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("hasContentLinks")]
        [Validation(Required=false)]
        public bool? HasContentLinks { get; set; }

        [NameInMap("isAtAll")]
        [Validation(Required=false)]
        public bool? IsAtAll { get; set; }

        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("receiverDingtalkIds")]
        [Validation(Required=false)]
        public List<string> ReceiverDingtalkIds { get; set; }

        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        [NameInMap("targetOpenConversationId")]
        [Validation(Required=false)]
        public string TargetOpenConversationId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
