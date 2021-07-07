// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("senderUid")]
        [Validation(Required=false)]
        public string SenderUid { get; set; }

        [NameInMap("receiverUid")]
        [Validation(Required=false)]
        public string ReceiverUid { get; set; }

        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

    }

}
