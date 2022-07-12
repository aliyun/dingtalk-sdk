// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ListActivateDevicesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListActivateDevicesResponseBodyResult> Result { get; set; }
        public class ListActivateDevicesResponseBodyResult : TeaModel {
            [NameInMap("bizExt")]
            [Validation(Required=false)]
            public string BizExt { get; set; }

            [NameInMap("deviceCallbackUrl")]
            [Validation(Required=false)]
            public string DeviceCallbackUrl { get; set; }

            [NameInMap("deviceCategory")]
            [Validation(Required=false)]
            public int? DeviceCategory { get; set; }

            [NameInMap("deviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            [NameInMap("deviceDetailUrl")]
            [Validation(Required=false)]
            public string DeviceDetailUrl { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("groupUuid")]
            [Validation(Required=false)]
            public string GroupUuid { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("typeUuid")]
            [Validation(Required=false)]
            public string TypeUuid { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
