// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ConnectorEventPushRequest : TeaModel {
        [NameInMap("deviceTypeUuid")]
        [Validation(Required=false)]
        public string DeviceTypeUuid { get; set; }

        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("input")]
        [Validation(Required=false)]
        public string Input { get; set; }

    }

}
