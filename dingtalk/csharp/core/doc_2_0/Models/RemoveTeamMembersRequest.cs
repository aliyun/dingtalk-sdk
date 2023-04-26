// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class RemoveTeamMembersRequest : TeaModel {
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<RemoveTeamMembersRequestMembers> Members { get; set; }
        public class RemoveTeamMembersRequestMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        [NameInMap("notify")]
        [Validation(Required=false)]
        public bool? Notify { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
