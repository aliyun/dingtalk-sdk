// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class RobotSendDingResponseBody : TeaModel {
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailedList { get; set; }

        [NameInMap("openDingId")]
        [Validation(Required=false)]
        public string OpenDingId { get; set; }

    }

}
