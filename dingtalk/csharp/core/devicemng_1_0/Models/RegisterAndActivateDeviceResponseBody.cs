// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RegisterAndActivateDeviceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RegisterAndActivateDeviceResponseBodyResult Result { get; set; }
        public class RegisterAndActivateDeviceResponseBodyResult : TeaModel {
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
            [NameInMap("deviceUuid")]
            [Validation(Required=false)]
            public string DeviceUuid { get; set; }
            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }
            [NameInMap("roleUuid")]
            [Validation(Required=false)]
            public string RoleUuid { get; set; }
            [NameInMap("typeUuid")]
            [Validation(Required=false)]
            public string TypeUuid { get; set; }
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
