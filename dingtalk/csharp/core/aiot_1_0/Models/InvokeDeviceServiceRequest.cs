// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0.Models
{
    public class InvokeDeviceServiceRequest : TeaModel {
        [NameInMap("args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public long? TimeoutSeconds { get; set; }

    }

}
