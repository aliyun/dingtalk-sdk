// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateRemoteClassDeviceRequest : TeaModel {
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("deviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

    }

}
