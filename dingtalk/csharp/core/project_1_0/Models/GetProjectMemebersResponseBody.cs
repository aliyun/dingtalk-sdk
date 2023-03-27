// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectMemebersResponseBody : TeaModel {
        /// <summary>
        /// 项目成员列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetProjectMemebersResponseBodyResult> Result { get; set; }
        public class GetProjectMemebersResponseBodyResult : TeaModel {
            /// <summary>
            /// 项目成员ID。
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// 项目角色，0=成员；1=管理员；2=拥有者。
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            /// <summary>
            /// 项目角色ID列表。
            /// </summary>
            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }

            /// <summary>
            /// 用户ID。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
