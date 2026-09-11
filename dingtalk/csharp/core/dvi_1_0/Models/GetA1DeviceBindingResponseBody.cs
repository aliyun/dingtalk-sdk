// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetA1DeviceBindingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetA1DeviceBindingResponseBodyResult Result { get; set; }
        public class GetA1DeviceBindingResponseBodyResult : TeaModel {
            [NameInMap("binding")]
            [Validation(Required=false)]
            public GetA1DeviceBindingResponseBodyResultBinding Binding { get; set; }
            public class GetA1DeviceBindingResponseBodyResultBinding : TeaModel {
                [NameInMap("bindTimestamp")]
                [Validation(Required=false)]
                public long? BindTimestamp { get; set; }

                [NameInMap("bindingStatus")]
                [Validation(Required=false)]
                public string BindingStatus { get; set; }

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
