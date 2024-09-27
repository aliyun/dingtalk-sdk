// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateCoupleGroupResponseBody : TeaModel {
        [NameInMap("appUserIds")]
        [Validation(Required=false)]
        public List<string> AppUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidX********xaw==</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14da****2760</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
