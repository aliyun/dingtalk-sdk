// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class RemoveRobotFromConversationRequest : TeaModel {
        /// <summary>
        /// 机器人在会话里的id
        /// </summary>
        [NameInMap("chatBotUserId")]
        [Validation(Required=false)]
        public string ChatBotUserId { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
