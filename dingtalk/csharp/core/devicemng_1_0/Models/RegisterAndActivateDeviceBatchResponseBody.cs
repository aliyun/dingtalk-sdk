// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RegisterAndActivateDeviceBatchResponseBody : TeaModel {
        [NameInMap("failItems")]
        [Validation(Required=false)]
        public List<RegisterAndActivateDeviceBatchResponseBodyFailItems> FailItems { get; set; }
        public class RegisterAndActivateDeviceBatchResponseBodyFailItems : TeaModel {
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult Result { get; set; }
            public class RegisterAndActivateDeviceBatchResponseBodyFailItemsResult : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }
                [NameInMap("deviceCallbackUrl")]
                [Validation(Required=false)]
                public string DeviceCallbackUrl { get; set; }
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
                [NameInMap("roleUuid")]
                [Validation(Required=false)]
                public string RoleUuid { get; set; }
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }
                [NameInMap("typeUuid")]
                [Validation(Required=false)]
                public string TypeUuid { get; set; }
                [NameInMap("userIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }
                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }
            };

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("successItems")]
        [Validation(Required=false)]
        public List<RegisterAndActivateDeviceBatchResponseBodySuccessItems> SuccessItems { get; set; }
        public class RegisterAndActivateDeviceBatchResponseBodySuccessItems : TeaModel {
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult Result { get; set; }
            public class RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }
                [NameInMap("deviceCallbackUrl")]
                [Validation(Required=false)]
                public string DeviceCallbackUrl { get; set; }
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
                [NameInMap("roleUuid")]
                [Validation(Required=false)]
                public string RoleUuid { get; set; }
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }
                [NameInMap("typeUuid")]
                [Validation(Required=false)]
                public string TypeUuid { get; set; }
                [NameInMap("userIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }
                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }
            };

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
