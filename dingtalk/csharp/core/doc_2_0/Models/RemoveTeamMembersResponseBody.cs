// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class RemoveTeamMembersResponseBody : TeaModel {
        [NameInMap("notInOrgMembers")]
        [Validation(Required=false)]
        public List<RemoveTeamMembersResponseBodyNotInOrgMembers> NotInOrgMembers { get; set; }
        public class RemoveTeamMembersResponseBodyNotInOrgMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        [NameInMap("saveSuccess")]
        [Validation(Required=false)]
        public bool? SaveSuccess { get; set; }

    }

}
