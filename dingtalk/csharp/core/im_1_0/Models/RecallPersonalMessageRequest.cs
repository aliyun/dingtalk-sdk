// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class RecallPersonalMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidxxxx3451=</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>msgxxx112</para>
        /// </summary>
        [NameInMap("openMessageId")]
        [Validation(Required=false)]
        public string OpenMessageId { get; set; }

    }

}
