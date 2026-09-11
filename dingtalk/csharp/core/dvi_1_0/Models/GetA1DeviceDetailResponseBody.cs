// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetA1DeviceDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetA1DeviceDetailResponseBodyResult Result { get; set; }
        public class GetA1DeviceDetailResponseBodyResult : TeaModel {
            [NameInMap("device")]
            [Validation(Required=false)]
            public GetA1DeviceDetailResponseBodyResultDevice Device { get; set; }
            public class GetA1DeviceDetailResponseBodyResultDevice : TeaModel {
                [NameInMap("bindTimestamp")]
                [Validation(Required=false)]
                public long? BindTimestamp { get; set; }

                [NameInMap("bindingStatus")]
                [Validation(Required=false)]
                public string BindingStatus { get; set; }

                [NameInMap("deviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

        }

    }

}
