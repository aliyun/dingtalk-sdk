// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartStreamOutResponseBody : TeaModel {
        [NameInMap("failStreamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailStreamMap { get; set; }

        [NameInMap("successStreamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SuccessStreamMap { get; set; }

    }

}
