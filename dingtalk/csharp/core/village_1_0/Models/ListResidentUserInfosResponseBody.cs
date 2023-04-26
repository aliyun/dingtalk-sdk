// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentUserInfosResponseBody : TeaModel {
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListResidentUserInfosResponseBodyUserList> UserList { get; set; }
        public class ListResidentUserInfosResponseBodyUserList : TeaModel {
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentUserInfosResponseBodyUserListRoles> Roles { get; set; }
            public class ListResidentUserInfosResponseBodyUserListRoles : TeaModel {
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

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
