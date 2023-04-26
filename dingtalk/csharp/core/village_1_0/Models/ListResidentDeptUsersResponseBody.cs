// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentDeptUsersResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListResidentDeptUsersResponseBodyUserList> UserList { get; set; }
        public class ListResidentDeptUsersResponseBodyUserList : TeaModel {
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentDeptUsersResponseBodyUserListRoles> Roles { get; set; }
            public class ListResidentDeptUsersResponseBodyUserListRoles : TeaModel {
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                [NameInMap("tagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
