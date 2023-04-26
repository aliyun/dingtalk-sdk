// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUnReadMessageResponseBody : TeaModel {
        [NameInMap("unReadCount")]
        [Validation(Required=false)]
        public long? UnReadCount { get; set; }

        [NameInMap("unReadItems")]
        [Validation(Required=false)]
        public List<QueryUnReadMessageResponseBodyUnReadItems> UnReadItems { get; set; }
        public class QueryUnReadMessageResponseBodyUnReadItems : TeaModel {
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("unReadCount")]
            [Validation(Required=false)]
            public long? UnReadCount { get; set; }

        }

    }

}
