// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListUserGroupMembersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListUserGroupMembersResponseBodyResult Result { get; set; }
        public class ListUserGroupMembersResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("members")]
            [Validation(Required=false)]
            public List<ListUserGroupMembersResponseBodyResultMembers> Members { get; set; }
            public class ListUserGroupMembersResponseBodyResultMembers : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("nextOffset")]
            [Validation(Required=false)]
            public long? NextOffset { get; set; }

        }

    }

}
