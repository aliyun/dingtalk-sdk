// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0.Models
{
    public class CreateGroupBlackboardRequest : TeaModel {
        /// <summary>
        /// 文本内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 群会话的 Id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 是否发DING
        /// </summary>
        [NameInMap("sendDing")]
        [Validation(Required=false)]
        public bool? SendDing { get; set; }

        /// <summary>
        /// 是否设为置顶
        /// </summary>
        [NameInMap("sticky")]
        [Validation(Required=false)]
        public bool? Sticky { get; set; }

        /// <summary>
        /// 业务唯一键
        /// </summary>
        [NameInMap("uniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// 操作用户的 userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
