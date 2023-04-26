// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateManagementGroupRequest : TeaModel {
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdateManagementGroupRequestMembers> Members { get; set; }
        public class UpdateManagementGroupRequestMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

        [NameInMap("resourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public UpdateManagementGroupRequestScope Scope { get; set; }
        public class UpdateManagementGroupRequestScope : TeaModel {
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

        }

    }

}
