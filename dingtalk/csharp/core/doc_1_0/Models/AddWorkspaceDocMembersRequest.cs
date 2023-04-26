// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class AddWorkspaceDocMembersRequest : TeaModel {
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<AddWorkspaceDocMembersRequestMembers> Members { get; set; }
        public class AddWorkspaceDocMembersRequestMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("roleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
