// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateManagementGroupRequest : TeaModel {
        /// <summary>
        /// 管理组名称
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 管理组成员
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdateManagementGroupRequestMembers> Members { get; set; }
        public class UpdateManagementGroupRequestMembers : TeaModel {
            /// <summary>
            /// 成员id
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// 成员类型
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

        /// <summary>
        /// 资源列表
        /// </summary>
        [NameInMap("resourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public UpdateManagementGroupRequestScope Scope { get; set; }
        public class UpdateManagementGroupRequestScope : TeaModel {
            /// <summary>
            /// 部门列表，只在scopeType=3 生效
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// 范围类型
            /// </summary>
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

        }

    }

}
