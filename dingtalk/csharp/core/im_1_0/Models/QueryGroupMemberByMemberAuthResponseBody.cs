// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMemberByMemberAuthResponseBody : TeaModel {
        [NameInMap("groupMemberList")]
        [Validation(Required=false)]
        public List<QueryGroupMemberByMemberAuthResponseBodyGroupMemberList> GroupMemberList { get; set; }
        public class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList : TeaModel {
            [NameInMap("groupNickName")]
            [Validation(Required=false)]
            public string GroupNickName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("profilePhotoUrl")]
            [Validation(Required=false)]
            public string ProfilePhotoUrl { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
