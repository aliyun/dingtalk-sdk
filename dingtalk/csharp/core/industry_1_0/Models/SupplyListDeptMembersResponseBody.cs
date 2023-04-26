// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListDeptMembersResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SupplyListDeptMembersResponseBodyList> List { get; set; }
        public class SupplyListDeptMembersResponseBodyList : TeaModel {
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            [NameInMap("memberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            [NameInMap("memberWorkNumber")]
            [Validation(Required=false)]
            public string MemberWorkNumber { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
