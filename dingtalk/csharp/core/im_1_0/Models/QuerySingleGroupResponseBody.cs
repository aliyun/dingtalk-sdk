// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySingleGroupResponseBody : TeaModel {
        /// <summary>
        /// 群会话列表
        /// </summary>
        [NameInMap("openConversations")]
        [Validation(Required=false)]
        public List<QuerySingleGroupResponseBodyOpenConversations> OpenConversations { get; set; }
        public class QuerySingleGroupResponseBodyOpenConversations : TeaModel {
            /// <summary>
            /// 客户appUserId
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 群会话Id
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 客服钉钉Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
