// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppRolesToMemberRequest : TeaModel {
        [NameInMap("memberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("memberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<AddAppRolesToMemberRequestRoleList> RoleList { get; set; }
        public class AddAppRolesToMemberRequestRoleList : TeaModel {
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("scopeVersion")]
            [Validation(Required=false)]
            public long? ScopeVersion { get; set; }

        }

    }

}
