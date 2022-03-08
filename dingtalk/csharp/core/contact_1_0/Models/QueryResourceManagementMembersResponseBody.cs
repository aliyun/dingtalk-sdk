// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryResourceManagementMembersResponseBody : TeaModel {
        /// <summary>
        /// 可管理资源的成员
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<QueryResourceManagementMembersResponseBodyMembers> Members { get; set; }
        public class QueryResourceManagementMembersResponseBodyMembers : TeaModel {
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

    }

}
