// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class SendRobotDingMessageRequest : TeaModel {
        [NameInMap("contentParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ContentParams { get; set; }

        [NameInMap("dingTemplateId")]
        [Validation(Required=false)]
        public string DingTemplateId { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
