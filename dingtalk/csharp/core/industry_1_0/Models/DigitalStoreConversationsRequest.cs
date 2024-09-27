// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreConversationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx店</para>
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

    }

}
