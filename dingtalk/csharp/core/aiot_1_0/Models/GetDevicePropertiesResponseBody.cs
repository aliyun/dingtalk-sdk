// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0.Models
{
    public class GetDevicePropertiesResponseBody : TeaModel {
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("productKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, PropertiesValue> Properties { get; set; }

        [NameInMap("snapshotAt")]
        [Validation(Required=false)]
        public string SnapshotAt { get; set; }

    }

}
