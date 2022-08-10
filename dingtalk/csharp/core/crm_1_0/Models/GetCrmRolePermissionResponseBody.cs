// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmRolePermissionResponseBody : TeaModel {
        /// <summary>
        /// CRM表单权限配置
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<GetCrmRolePermissionResponseBodyPermissions> Permissions { get; set; }
        public class GetCrmRolePermissionResponseBodyPermissions : TeaModel {
            /// <summary>
            /// 是否是默认权限
            /// </summary>
            [NameInMap("defaultRole")]
            [Validation(Required=false)]
            public bool? DefaultRole { get; set; }

            /// <summary>
            /// 字段权限
            /// </summary>
            [NameInMap("fieldScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> FieldScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsFieldScopes : TeaModel {
                /// <summary>
                /// 字段权限点
                /// </summary>
                [NameInMap("fieldActions")]
                [Validation(Required=false)]
                public List<string> FieldActions { get; set; }

                /// <summary>
                /// 字段id
                /// </summary>
                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

            }

            /// <summary>
            /// 权限组适用范围配置
            /// </summary>
            [NameInMap("managingScopeList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> ManagingScopeList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList : TeaModel {
                /// <summary>
                /// 扩展信息
                /// </summary>
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
                };

                /// <summary>
                /// 是否是主管
                /// </summary>
                [NameInMap("manager")]
                [Validation(Required=false)]
                public bool? Manager { get; set; }

                /// <summary>
                /// 管理范围类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 操作范围
            /// </summary>
            [NameInMap("operateScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> OperateScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsOperateScopes : TeaModel {
                /// <summary>
                /// 是否有权限
                /// </summary>
                [NameInMap("hasAuth")]
                [Validation(Required=false)]
                public bool? HasAuth { get; set; }

                /// <summary>
                /// 操作范围类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 资源id
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// 权限组id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public double? RoleId { get; set; }

            /// <summary>
            /// 权限组配置
            /// </summary>
            [NameInMap("roleMemberList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> RoleMemberList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList : TeaModel {
                /// <summary>
                /// 角色值
                /// </summary>
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// 角色名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 角色类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 角色的userId
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 权限组名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
