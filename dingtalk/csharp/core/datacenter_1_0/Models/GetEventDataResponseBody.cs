// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetEventDataResponseBody : TeaModel {
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public Dictionary<string, object> Value { get; set; }

    }

}
