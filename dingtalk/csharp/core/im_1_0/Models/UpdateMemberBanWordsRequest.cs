// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateMemberBanWordsRequest : TeaModel {
        /// <summary>
        /// 禁言持续时长（单位：毫秒）
        /// </summary>
        [NameInMap("muteDuration")]
        [Validation(Required=false)]
        public long? MuteDuration { get; set; }

        /// <summary>
        /// 禁言状态(0表示取消禁言，1表示禁言)
        /// </summary>
        [NameInMap("muteStatus")]
        [Validation(Required=false)]
        public int? MuteStatus { get; set; }

        /// <summary>
        /// 开放群id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 需要禁言或取消禁言的群成员列表
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
