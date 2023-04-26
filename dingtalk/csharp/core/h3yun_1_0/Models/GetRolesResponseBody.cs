// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetRolesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRolesResponseBodyData Data { get; set; }
        public class GetRolesResponseBodyData : TeaModel {
            [NameInMap("roleGroups")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoleGroups> RoleGroups { get; set; }
            public class GetRolesResponseBodyDataRoleGroups : TeaModel {
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("groupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoles> Roles { get; set; }
            public class GetRolesResponseBodyDataRoles : TeaModel {
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("roleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                [NameInMap("roleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
