// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMemberResponseBody : TeaModel {
        [NameInMap("groupMembers")]
        [Validation(Required=false)]
        public List<QueryGroupMemberResponseBodyGroupMembers> GroupMembers { get; set; }
        public class QueryGroupMemberResponseBodyGroupMembers : TeaModel {
            [NameInMap("groupMemberAvatar")]
            [Validation(Required=false)]
            public string GroupMemberAvatar { get; set; }

            [NameInMap("groupMemberDynamics")]
            [Validation(Required=false)]
            public string GroupMemberDynamics { get; set; }

            [NameInMap("groupMemberId")]
            [Validation(Required=false)]
            public string GroupMemberId { get; set; }

            [NameInMap("groupMemberName")]
            [Validation(Required=false)]
            public string GroupMemberName { get; set; }

            [NameInMap("groupMemberType")]
            [Validation(Required=false)]
            public int? GroupMemberType { get; set; }

        }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
