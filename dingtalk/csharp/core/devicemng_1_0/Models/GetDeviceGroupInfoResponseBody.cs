// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class GetDeviceGroupInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDeviceGroupInfoResponseBodyResult Result { get; set; }
        public class GetDeviceGroupInfoResponseBodyResult : TeaModel {
            [NameInMap("devices")]
            [Validation(Required=false)]
            public List<GetDeviceGroupInfoResponseBodyResultDevices> Devices { get; set; }
            public class GetDeviceGroupInfoResponseBodyResultDevices : TeaModel {
                [NameInMap("deviceCode")]
                [Validation(Required=false)]
                public string DeviceCode { get; set; }

                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("deviceUuid")]
                [Validation(Required=false)]
                public string DeviceUuid { get; set; }

                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("ownerUser")]
            [Validation(Required=false)]
            public string OwnerUser { get; set; }

            [NameInMap("subAdminUsers")]
            [Validation(Required=false)]
            public List<string> SubAdminUsers { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("users")]
            [Validation(Required=false)]
            public Dictionary<string, string> Users { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
