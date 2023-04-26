// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class PushCustomerGroupMessageRequest : TeaModel {
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("msgKey")]
        [Validation(Required=false)]
        public string MsgKey { get; set; }

        [NameInMap("msgParam")]
        [Validation(Required=false)]
        public string MsgParam { get; set; }

    }

}
