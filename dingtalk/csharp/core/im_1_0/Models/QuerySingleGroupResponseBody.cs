// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySingleGroupResponseBody : TeaModel {
        /// <summary>
        /// 群会话列表。
        /// </summary>
        [NameInMap("openConversations")]
        [Validation(Required=false)]
        public List<QuerySingleGroupResponseBodyOpenConversations> OpenConversations { get; set; }
        public class QuerySingleGroupResponseBodyOpenConversations : TeaModel {
            /// <summary>
            /// 钉外用户在业务系统内的唯一标识。
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 群会话Id。
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 钉内用户userId。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
