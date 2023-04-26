// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListUserIndustryRolesResponseBody : TeaModel {
        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<ListUserIndustryRolesResponseBodyRoleList> RoleList { get; set; }
        public class ListUserIndustryRolesResponseBodyRoleList : TeaModel {
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

        }

    }

}
