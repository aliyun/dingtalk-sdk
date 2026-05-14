// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>群会话Id</para>
        /// </summary>
        [NameInMap("chatid")]
        [Validation(Required=false)]
        public string Chatid { get; set; }

        /// <summary>
        /// <para>会话类型标记</para>
        /// </summary>
        [NameInMap("conversationTag")]
        [Validation(Required=false)]
        public long? ConversationTag { get; set; }

        /// <summary>
        /// <para>开放群会话Id</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
