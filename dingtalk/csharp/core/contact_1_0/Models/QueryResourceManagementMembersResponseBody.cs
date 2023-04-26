// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryResourceManagementMembersResponseBody : TeaModel {
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<QueryResourceManagementMembersResponseBodyMembers> Members { get; set; }
        public class QueryResourceManagementMembersResponseBodyMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

    }

}
