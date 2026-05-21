// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class UpdateCustomRobotOutgoingResponseBody : TeaModel {
        [NameInMap("originalUrl")]
        [Validation(Required=false)]
        public string OriginalUrl { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("targetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

    }

}
