// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class BatchSendRequest : TeaModel {
        [NameInMap("appUids")]
        [Validation(Required=false)]
        public List<string> AppUids { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("conversationIds")]
        [Validation(Required=false)]
        public List<string> ConversationIds { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
