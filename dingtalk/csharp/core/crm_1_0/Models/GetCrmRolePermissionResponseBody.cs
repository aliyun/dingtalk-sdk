// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmRolePermissionResponseBody : TeaModel {
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<GetCrmRolePermissionResponseBodyPermissions> Permissions { get; set; }
        public class GetCrmRolePermissionResponseBodyPermissions : TeaModel {
            [NameInMap("defaultRole")]
            [Validation(Required=false)]
            public bool? DefaultRole { get; set; }

            [NameInMap("fieldScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> FieldScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsFieldScopes : TeaModel {
                [NameInMap("fieldActions")]
                [Validation(Required=false)]
                public List<string> FieldActions { get; set; }

                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

            }

            [NameInMap("managingScopeList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> ManagingScopeList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList : TeaModel {
                [NameInMap("ext")]
                [Validation(Required=false)]
                public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt Ext { get; set; }
                public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt : TeaModel {
                    [NameInMap("deptIdList")]
                    [Validation(Required=false)]
                    public List<double?> DeptIdList { get; set; }

                    [NameInMap("userIdList")]
                    [Validation(Required=false)]
                    public List<string> UserIdList { get; set; }

                }

                [NameInMap("manager")]
                [Validation(Required=false)]
                public bool? Manager { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("operateScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> OperateScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsOperateScopes : TeaModel {
                [NameInMap("hasAuth")]
                [Validation(Required=false)]
                public bool? HasAuth { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("roleId")]
            [Validation(Required=false)]
            public double? RoleId { get; set; }

            [NameInMap("roleMemberList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> RoleMemberList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList : TeaModel {
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
