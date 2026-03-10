// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_search_ask_1_0.Models
{
    public class FetchLoginStatusDevicesResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<FetchLoginStatusDevicesResponseBodyResult> Result { get; set; }
        public class FetchLoginStatusDevicesResponseBodyResult : TeaModel {
            [NameInMap("deviceList")]
            [Validation(Required=false)]
            public List<FetchLoginStatusDevicesResponseBodyResultDeviceList> DeviceList { get; set; }
            public class FetchLoginStatusDevicesResponseBodyResultDeviceList : TeaModel {
                [NameInMap("actionTimestamp")]
                [Validation(Required=false)]
                public long? ActionTimestamp { get; set; }

                [NameInMap("clientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                [NameInMap("isLoggedIn")]
                [Validation(Required=false)]
                public bool? IsLoggedIn { get; set; }

                [NameInMap("openDeviceId")]
                [Validation(Required=false)]
                public string OpenDeviceId { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
