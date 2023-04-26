// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDevicePropertiesRequest : TeaModel {
        [NameInMap("propertyNames")]
        [Validation(Required=false)]
        public List<string> PropertyNames { get; set; }

        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("deviceUnionId")]
        [Validation(Required=false)]
        public string DeviceUnionId { get; set; }

        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

    }

}
