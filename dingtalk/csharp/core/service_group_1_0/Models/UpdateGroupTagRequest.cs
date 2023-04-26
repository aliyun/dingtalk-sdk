// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UpdateGroupTagRequest : TeaModel {
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        [NameInMap("tagNames")]
        [Validation(Required=false)]
        public List<string> TagNames { get; set; }

        [NameInMap("updateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
