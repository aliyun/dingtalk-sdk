// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class SendRobotMessageRequest : TeaModel {
        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        [NameInMap("atAppUids")]
        [Validation(Required=false)]
        public List<string> AtAppUids { get; set; }

        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        [NameInMap("atUsers")]
        [Validation(Required=false)]
        public List<string> AtUsers { get; set; }

        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("msgMediaIdParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> MsgMediaIdParamMap { get; set; }

        [NameInMap("msgParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> MsgParamMap { get; set; }

        [NameInMap("msgTemplateId")]
        [Validation(Required=false)]
        public string MsgTemplateId { get; set; }

        [NameInMap("receiverAppUids")]
        [Validation(Required=false)]
        public List<string> ReceiverAppUids { get; set; }

        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("targetOpenConversationId")]
        [Validation(Required=false)]
        public string TargetOpenConversationId { get; set; }

    }

}
