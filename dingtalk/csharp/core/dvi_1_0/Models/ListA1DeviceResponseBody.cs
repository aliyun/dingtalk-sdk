// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class ListA1DeviceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListA1DeviceResponseBodyResult Result { get; set; }
        public class ListA1DeviceResponseBodyResult : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListA1DeviceResponseBodyResultItems> Items { get; set; }
            public class ListA1DeviceResponseBodyResultItems : TeaModel {
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

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
