// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUnReadMessageResponseBody : TeaModel {
        /// <summary>
        /// 未读消息数。
        /// </summary>
        [NameInMap("unReadCount")]
        [Validation(Required=false)]
        public long? UnReadCount { get; set; }

        /// <summary>
        /// 未读消息列表。
        /// </summary>
        [NameInMap("unReadItems")]
        [Validation(Required=false)]
        public List<QueryUnReadMessageResponseBodyUnReadItems> UnReadItems { get; set; }
        public class QueryUnReadMessageResponseBodyUnReadItems : TeaModel {
            /// <summary>
            /// 群会话Id。
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 未读消息数。
            /// </summary>
            [NameInMap("unReadCount")]
            [Validation(Required=false)]
            public long? UnReadCount { get; set; }

        }

    }

}
