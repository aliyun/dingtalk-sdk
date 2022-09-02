// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetRolesResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRolesResponseBodyData Data { get; set; }
        public class GetRolesResponseBodyData : TeaModel {
            /// <summary>
            /// 角色组数组
            /// </summary>
            [NameInMap("roleGroups")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoleGroups> RoleGroups { get; set; }
            public class GetRolesResponseBodyDataRoleGroups : TeaModel {
                /// <summary>
                /// 所属企业id
                /// </summary>
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                /// <summary>
                /// 描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 组编码
                /// </summary>
                [NameInMap("groupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// 组id
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// 组名称
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// 状态。Active=激活、Inactive=未激活，Unspecified=未指定状态
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// 可见性。All=全部可见、Normal=普通可见、OnlyAdmin=只有管理的时候可见、OnlyOrganization=本组织范围可见
                /// </summary>
                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            /// <summary>
            /// 角色数组
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoles> Roles { get; set; }
            public class GetRolesResponseBodyDataRoles : TeaModel {
                /// <summary>
                /// 所属企业id
                /// </summary>
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                /// <summary>
                /// 描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 所属的角色组id
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// 角色编码
                /// </summary>
                [NameInMap("roleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// 角色id
                /// </summary>
                [NameInMap("roleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// 角色名称
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// 状态。Active=激活、Inactive=未激活，Unspecified=未指定状态
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// 可见性。All=全部可见、Normal=普通可见、OnlyAdmin=只有管理的时候可见、OnlyOrganization=本组织范围可见
                /// </summary>
                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
