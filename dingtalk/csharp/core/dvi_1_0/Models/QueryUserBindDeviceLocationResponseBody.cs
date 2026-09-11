// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryUserBindDeviceLocationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryUserBindDeviceLocationResponseBodyResult> Result { get; set; }
        public class QueryUserBindDeviceLocationResponseBodyResult : TeaModel {
            [NameInMap("latestLocation")]
            [Validation(Required=false)]
            public QueryUserBindDeviceLocationResponseBodyResultLatestLocation LatestLocation { get; set; }
            public class QueryUserBindDeviceLocationResponseBodyResultLatestLocation : TeaModel {
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
