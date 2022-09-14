// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListTeamMembersResponseBody : TeaModel {
        /// <summary>
        /// 小组成员列表。
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListTeamMembersResponseBodyMembers> Members { get; set; }
        public class ListTeamMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// 成员id。
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// 成员类型。
            /// 1-群；2-用户；3-组织；4-部门；5-虚拟组。
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            /// <summary>
            /// 成员名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 成员角色。
            /// 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        /// <summary>
        /// 小组名称。
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

    }

}
