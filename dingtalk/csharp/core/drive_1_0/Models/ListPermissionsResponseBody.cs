// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyMembers> Members { get; set; }
        public class ListPermissionsResponseBodyMembers : TeaModel {
            [NameInMap("extend")]
            [Validation(Required=false)]
            public bool? Extend { get; set; }

            [NameInMap("member")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyMembersMember Member { get; set; }
            public class ListPermissionsResponseBodyMembersMember : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("outMembers")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyOutMembers> OutMembers { get; set; }
        public class ListPermissionsResponseBodyOutMembers : TeaModel {
            [NameInMap("extend")]
            [Validation(Required=false)]
            public bool? Extend { get; set; }

            [NameInMap("member")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyOutMembersMember Member { get; set; }
            public class ListPermissionsResponseBodyOutMembersMember : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

    }

}
