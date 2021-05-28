// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppRolesToMemberRequest : TeaModel {
        /// <summary>
        /// 执行用户userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>
        [NameInMap("memberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// 人员类型，“DEPT”表示部门，“USER”表示员工
        /// </summary>
        [NameInMap("memberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

        /// <summary>
        /// 角色Id列表
        /// </summary>
        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<AddAppRolesToMemberRequestRoleList> RoleList { get; set; }
        public class AddAppRolesToMemberRequestRoleList : TeaModel {
            /// <summary>
            /// 角色ID
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 角色范围版本号
            /// </summary>
            [NameInMap("scopeVersion")]
            [Validation(Required=false)]
            public long? ScopeVersion { get; set; }

        }

    }

}
