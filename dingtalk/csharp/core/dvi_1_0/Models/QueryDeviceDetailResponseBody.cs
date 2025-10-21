// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryDeviceDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryDeviceDetailResponseBodyResult> Result { get; set; }
        public class QueryDeviceDetailResponseBodyResult : TeaModel {
            [NameInMap("bindTimestamp")]
            [Validation(Required=false)]
            public long? BindTimestamp { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
