// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class OpenSearchGroupListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public OpenSearchGroupListResponseBodyResult Result { get; set; }
        public class OpenSearchGroupListResponseBodyResult : TeaModel {
            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<OpenSearchGroupListResponseBodyResultGroupList> GroupList { get; set; }
            public class OpenSearchGroupListResponseBodyResultGroupList : TeaModel {
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("memberCount")]
                [Validation(Required=false)]
                public int? MemberCount { get; set; }

                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
