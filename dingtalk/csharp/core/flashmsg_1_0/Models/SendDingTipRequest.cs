// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class SendDingTipRequest : TeaModel {
        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        [NameInMap("link")]
        [Validation(Required=false)]
        public SendDingTipRequestLink Link { get; set; }
        public class SendDingTipRequestLink : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("linkUrl")]
            [Validation(Required=false)]
            public string LinkUrl { get; set; }

            [NameInMap("picMediaId")]
            [Validation(Required=false)]
            public string PicMediaId { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("receiverUserId")]
        [Validation(Required=false)]
        public List<string> ReceiverUserId { get; set; }

        [NameInMap("textContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

    }

}
