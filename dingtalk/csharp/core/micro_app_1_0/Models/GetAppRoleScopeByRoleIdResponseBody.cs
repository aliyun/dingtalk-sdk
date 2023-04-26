// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetAppRoleScopeByRoleIdResponseBody : TeaModel {
        [NameInMap("canManageRole")]
        [Validation(Required=false)]
        public bool? CanManageRole { get; set; }

        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        [NameInMap("roleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        [NameInMap("scopeVersion")]
        [Validation(Required=false)]
        public string ScopeVersion { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
