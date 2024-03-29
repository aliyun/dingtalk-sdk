// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryGroupMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryGroupMemberResponseBodyResult Result { get; set; }
        public class QueryGroupMemberResponseBodyResult : TeaModel {
            [NameInMap("groupMemberList")]
            [Validation(Required=false)]
            public List<QueryGroupMemberResponseBodyResultGroupMemberList> GroupMemberList { get; set; }
            public class QueryGroupMemberResponseBodyResultGroupMemberList : TeaModel {
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                [NameInMap("isUser")]
                [Validation(Required=false)]
                public bool? IsUser { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public bool? Owner { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
