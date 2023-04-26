// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySingleGroupResponseBody : TeaModel {
        [NameInMap("openConversations")]
        [Validation(Required=false)]
        public List<QuerySingleGroupResponseBodyOpenConversations> OpenConversations { get; set; }
        public class QuerySingleGroupResponseBodyOpenConversations : TeaModel {
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
