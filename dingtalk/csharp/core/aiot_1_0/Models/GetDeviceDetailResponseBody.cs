// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0.Models
{
    public class GetDeviceDetailResponseBody : TeaModel {
        [NameInMap("activatedAt")]
        [Validation(Required=false)]
        public string ActivatedAt { get; set; }

        [NameInMap("connectivity")]
        [Validation(Required=false)]
        public string Connectivity { get; set; }

        [NameInMap("lastOfflineTime")]
        [Validation(Required=false)]
        public string LastOfflineTime { get; set; }

        [NameInMap("lastOnlineTime")]
        [Validation(Required=false)]
        public string LastOnlineTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
