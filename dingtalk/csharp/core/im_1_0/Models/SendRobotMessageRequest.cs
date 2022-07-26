// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendRobotMessageRequest : TeaModel {
        /// <summary>
        /// @群所有人为true， 默认false。
        /// </summary>
        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        /// <summary>
        /// @钉外在业务系统内的唯一标识（openId）。
        /// </summary>
        [NameInMap("atAppUserId")]
        [Validation(Required=false)]
        public string AtAppUserId { get; set; }

        /// <summary>
        /// @钉内用户在业务系统内的唯一标识（dingUserId）。
        /// </summary>
        [NameInMap("atDingUserId")]
        [Validation(Required=false)]
        public string AtDingUserId { get; set; }

        /// <summary>
        /// 消息体内容，按照下面参考示例格式上传。
        /// </summary>
        [NameInMap("msgContent")]
        [Validation(Required=false)]
        public string MsgContent { get; set; }

        /// <summary>
        /// 消息类型 文本：text，图片：photo，markdown：markdown，actionCard：actionCard。
        /// </summary>
        [NameInMap("msgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// 群聊openConversationIds
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

    }

}
