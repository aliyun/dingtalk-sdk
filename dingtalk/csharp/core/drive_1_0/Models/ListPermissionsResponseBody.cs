// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyMembers> Members { get; set; }
        public class ListPermissionsResponseBodyMembers : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public bool? Extend { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outMembers")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyOutMembers> OutMembers { get; set; }
        public class ListPermissionsResponseBodyOutMembers : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public bool? Extend { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

    }

}
