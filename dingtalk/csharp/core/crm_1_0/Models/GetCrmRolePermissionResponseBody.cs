// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmRolePermissionResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<GetCrmRolePermissionResponseBodyPermissions> Permissions { get; set; }
        public class GetCrmRolePermissionResponseBodyPermissions : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("defaultRole")]
            [Validation(Required=false)]
            public bool? DefaultRole { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> FieldScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsFieldScopes : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("fieldActions")]
                [Validation(Required=false)]
                public List<string> FieldActions { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("managingScopeList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> ManagingScopeList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ext")]
                [Validation(Required=false)]
                public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt Ext { get; set; }
                public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptIdList")]
                    [Validation(Required=false)]
                    public List<double?> DeptIdList { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("userIdList")]
                    [Validation(Required=false)]
                    public List<string> UserIdList { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("manager")]
                [Validation(Required=false)]
                public bool? Manager { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("operateScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> OperateScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsOperateScopes : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("hasAuth")]
                [Validation(Required=false)]
                public bool? HasAuth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public double? RoleId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleMemberList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> RoleMemberList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
