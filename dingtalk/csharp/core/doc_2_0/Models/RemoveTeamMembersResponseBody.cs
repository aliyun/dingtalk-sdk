// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class RemoveTeamMembersResponseBody : TeaModel {
        [NameInMap("notInOrgMembers")]
        [Validation(Required=false)]
        public List<RemoveTeamMembersResponseBodyNotInOrgMembers> NotInOrgMembers { get; set; }
        public class RemoveTeamMembersResponseBodyNotInOrgMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>YEp3JcM******UIbhwiE</para>
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小钉</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        [NameInMap("saveSuccess")]
        [Validation(Required=false)]
        public bool? SaveSuccess { get; set; }

    }

}
