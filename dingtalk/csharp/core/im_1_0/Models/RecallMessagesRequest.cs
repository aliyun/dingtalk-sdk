// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class RecallMessagesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidc4iLyQBuHFQRvzxznz204Q</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("openTaskId")]
        [Validation(Required=false)]
        public string OpenTaskId { get; set; }

    }

}
