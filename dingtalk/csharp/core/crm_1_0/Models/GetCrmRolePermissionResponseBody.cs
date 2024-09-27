// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmRolePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<GetCrmRolePermissionResponseBodyPermissions> Permissions { get; set; }
        public class GetCrmRolePermissionResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("defaultRole")]
            [Validation(Required=false)]
            public bool? DefaultRole { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> FieldScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsFieldScopes : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("fieldActions")]
                [Validation(Required=false)]
                public List<string> FieldActions { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;DDSelectField-KI5S975E&quot;</para>
                /// </summary>
                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("managingScopeList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> ManagingScopeList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ext")]
                [Validation(Required=false)]
                public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt Ext { get; set; }
                public class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("deptIdList")]
                    [Validation(Required=false)]
                    public List<double?> DeptIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("userIdList")]
                    [Validation(Required=false)]
                    public List<string> UserIdList { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false 如果是主管，要做逻辑的单独处理。比如如果设置了管理下属或当前部门，只管理他是主管的部门</para>
                /// </summary>
                [NameInMap("manager")]
                [Validation(Required=false)]
                public bool? Manager { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10_own 自己负责的 15_all_org 全公司 20_selfDept 同层级 30_selfSubDept 下属的 40_customized 自定义的</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("operateScopes")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> OperateScopes { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsOperateScopes : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasAuth")]
                [Validation(Required=false)]
                public bool? HasAuth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>操作类型      * 发起：OPERATE_CREATE      * 查看：OPERATE_VIEW      * 编辑：OPERATE_EDIT      * 删除：OPERATE_DELETE      * 打印：OPERATE_PRINT      * 分配：ASSIGN      * 转交：TRANS      * 导入：IMPORT      * 导出：EXPORT</description></item>
                /// </list>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROC-478E50CA-856C-4C08-B806-E664D4CEC8C4</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12821738</para>
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public double? RoleId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("roleMemberList")]
            [Validation(Required=false)]
            public List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> RoleMemberList { get; set; }
            public class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>可以是员工 uid，可以是部门 ID 等，根据 type 确定</para>
                /// </summary>
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user：组织成员   dept：部门   tag：标签  org：组织     org_res_admin：组织管理员</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager1234</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>销售权限组</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
