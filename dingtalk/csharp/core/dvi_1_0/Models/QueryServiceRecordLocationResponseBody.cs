// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryServiceRecordLocationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryServiceRecordLocationResponseBodyResult> Result { get; set; }
        public class QueryServiceRecordLocationResponseBodyResult : TeaModel {
            [NameInMap("locations")]
            [Validation(Required=false)]
            public List<QueryServiceRecordLocationResponseBodyResultLocations> Locations { get; set; }
            public class QueryServiceRecordLocationResponseBodyResultLocations : TeaModel {
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

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

        }

    }

}
