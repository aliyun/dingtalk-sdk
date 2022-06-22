// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListRenterMembersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListRenterMembersResponseBodyResult> Result { get; set; }
        public class CampusListRenterMembersResponseBodyResult : TeaModel {
            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("inviteState")]
            [Validation(Required=false)]
            public string InviteState { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
