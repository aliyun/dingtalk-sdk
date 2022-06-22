// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class RoleMemberMapValue : TeaModel {
        /// <summary>
        /// 角色唯一标识
        /// </summary>
        [NameInMap("roleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// 成员信息列表
        /// </summary>
        [NameInMap("memberList")]
        [Validation(Required=false)]
        public List<RoleMemberMapValueMemberList> MemberList { get; set; }
        public class RoleMemberMapValueMemberList : TeaModel {
            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 昵称
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// 头像URL
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

        }

    }

}
