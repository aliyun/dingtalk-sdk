// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentDeptUsersResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListResidentDeptUsersResponseBodyUserList> UserList { get; set; }
        public class ListResidentDeptUsersResponseBodyUserList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentDeptUsersResponseBodyUserListRoles> Roles { get; set; }
            public class ListResidentDeptUsersResponseBodyUserListRoles : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("tagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
