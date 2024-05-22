// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryRecentConversationsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryRecentConversationsResponseBodyResult Result { get; set; }
        public class QueryRecentConversationsResponseBodyResult : TeaModel {
            [NameInMap("conversationList")]
            [Validation(Required=false)]
            public List<QueryRecentConversationsResponseBodyResultConversationList> ConversationList { get; set; }
            public class QueryRecentConversationsResponseBodyResultConversationList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("conversationType")]
                [Validation(Required=false)]
                public int? ConversationType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("memberCount")]
                [Validation(Required=false)]
                public string MemberCount { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
