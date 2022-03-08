// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateMemberGroupNickRequest : TeaModel {
        /// <summary>
        /// 群昵称
        /// </summary>
        [NameInMap("groupNick")]
        [Validation(Required=false)]
        public string GroupNick { get; set; }

        /// <summary>
        /// 开放群ID
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
