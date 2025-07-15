// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetWorkspacePermissionScopesResponseBody : TeaModel {
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<GetWorkspacePermissionScopesResponseBodyMembers> Members { get; set; }
        public class GetWorkspacePermissionScopesResponseBodyMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberRole")]
            [Validation(Required=false)]
            public string MemberRole { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

    }

}
