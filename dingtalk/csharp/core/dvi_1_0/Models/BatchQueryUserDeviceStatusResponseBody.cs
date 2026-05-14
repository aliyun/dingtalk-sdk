// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class BatchQueryUserDeviceStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchQueryUserDeviceStatusResponseBodyResult Result { get; set; }
        public class BatchQueryUserDeviceStatusResponseBodyResult : TeaModel {
            [NameInMap("userDeviceStatusMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<ResultUserDeviceStatusMapValue>> UserDeviceStatusMap { get; set; }

        }

    }

}
