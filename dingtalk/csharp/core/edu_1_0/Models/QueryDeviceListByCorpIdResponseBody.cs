// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryDeviceListByCorpIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryDeviceListByCorpIdResponseBodyResult Result { get; set; }
        public class QueryDeviceListByCorpIdResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryDeviceListByCorpIdResponseBodyResultList> List { get; set; }
            public class QueryDeviceListByCorpIdResponseBodyResultList : TeaModel {
                [NameInMap("appStatus")]
                [Validation(Required=false)]
                public int? AppStatus { get; set; }

                [NameInMap("deviceCode")]
                [Validation(Required=false)]
                public string DeviceCode { get; set; }

                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
