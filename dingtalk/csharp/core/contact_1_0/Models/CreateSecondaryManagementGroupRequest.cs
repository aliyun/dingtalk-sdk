// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateSecondaryManagementGroupRequest : TeaModel {
        /// <summary>
        /// 管理组名称
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 管理组成员列表
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateSecondaryManagementGroupRequestMembers> Members { get; set; }
        public class CreateSecondaryManagementGroupRequestMembers : TeaModel {
            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// 员工类型
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

        /// <summary>
        /// 资源id列表
        /// </summary>
        [NameInMap("resourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 管理组权限范围信息
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public CreateSecondaryManagementGroupRequestScope Scope { get; set; }
        public class CreateSecondaryManagementGroupRequestScope : TeaModel {
            /// <summary>
            /// 部门id列表
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// 权限范围
            /// </summary>
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

        }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
