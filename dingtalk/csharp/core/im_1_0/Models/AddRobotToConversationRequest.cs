// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddRobotToConversationRequest : TeaModel {
        /// <summary>
        /// 机器人meidaId
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 机器人名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 机器人编码
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
