// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreConversationsResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<DigitalStoreConversationsResponseBodyContent> Content { get; set; }
        public class DigitalStoreConversationsResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx店</para>
            /// </summary>
            [NameInMap("conversationTitle")]
            [Validation(Required=false)]
            public string ConversationTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>store</para>
            /// </summary>
            [NameInMap("conversationType")]
            [Validation(Required=false)]
            public string ConversationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cid1234984881</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

    }

}
