// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CloseTopboxRequest : TeaModel {
        /// <summary>
        /// 会话类型。
        /// </summary>
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        /// <summary>
        /// 酷应用编码。
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// 群模板id。
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// 会话id。
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 唯一标识一张卡片的外部ID。
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 单聊助手会话，机器人编码。
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 单聊助手会话，用户unionId。
        /// </summary>
        [NameInMap("unoinId")]
        [Validation(Required=false)]
        public string UnoinId { get; set; }

        /// <summary>
        /// 单聊助手会话，用户userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
