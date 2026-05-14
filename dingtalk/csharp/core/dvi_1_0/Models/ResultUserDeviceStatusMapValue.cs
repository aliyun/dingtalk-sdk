// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class ResultUserDeviceStatusMapValue : TeaModel {
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public ResultUserDeviceStatusMapValueStatus Status { get; set; }
        public class ResultUserDeviceStatusMapValueStatus : TeaModel {
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
