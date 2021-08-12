// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class AddGroupMembersRequest : TeaModel {
        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<AddGroupMembersRequestMembers> Members { get; set; }
        public class AddGroupMembersRequestMembers : TeaModel {
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
