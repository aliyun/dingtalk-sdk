// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDeviceIpByCodeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryDeviceIpByCodeResponseBodyResult Result { get; set; }
        public class QueryDeviceIpByCodeResponseBodyResult : TeaModel {
            [NameInMap("deviceIp")]
            [Validation(Required=false)]
            public string DeviceIp { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
