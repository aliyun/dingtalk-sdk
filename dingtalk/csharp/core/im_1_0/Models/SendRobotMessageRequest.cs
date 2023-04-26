// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendRobotMessageRequest : TeaModel {
        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        [NameInMap("atAppUserId")]
        [Validation(Required=false)]
        public string AtAppUserId { get; set; }

        [NameInMap("atDingUserId")]
        [Validation(Required=false)]
        public string AtDingUserId { get; set; }

        [NameInMap("msgContent")]
        [Validation(Required=false)]
        public string MsgContent { get; set; }

        [NameInMap("msgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
