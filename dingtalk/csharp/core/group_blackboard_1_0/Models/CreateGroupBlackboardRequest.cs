// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0.Models
{
    public class CreateGroupBlackboardRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("sendDing")]
        [Validation(Required=false)]
        public bool? SendDing { get; set; }

        [NameInMap("sticky")]
        [Validation(Required=false)]
        public bool? Sticky { get; set; }

        [NameInMap("uniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
