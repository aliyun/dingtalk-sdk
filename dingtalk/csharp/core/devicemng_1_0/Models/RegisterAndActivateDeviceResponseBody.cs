// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RegisterAndActivateDeviceResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public RegisterAndActivateDeviceResponseBodyResult Result { get; set; }
        public class RegisterAndActivateDeviceResponseBodyResult : TeaModel {
            [NameInMap("deviceCategory")]
            [Validation(Required=false)]
            public int? DeviceCategory { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceDetailUrl")]
            [Validation(Required=false)]
            public string DeviceDetailUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceUuid")]
            [Validation(Required=false)]
            public string DeviceUuid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleUuid")]
            [Validation(Required=false)]
            public string RoleUuid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("typeUuid")]
            [Validation(Required=false)]
            public string TypeUuid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
