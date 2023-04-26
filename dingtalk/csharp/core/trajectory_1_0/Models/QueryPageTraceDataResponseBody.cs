// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryPageTraceDataResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryPageTraceDataResponseBodyList> List { get; set; }
        public class QueryPageTraceDataResponseBodyList : TeaModel {
            [NameInMap("coordinates")]
            [Validation(Required=false)]
            public QueryPageTraceDataResponseBodyListCoordinates Coordinates { get; set; }
            public class QueryPageTraceDataResponseBodyListCoordinates : TeaModel {
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public float? Latitude { get; set; }

                [NameInMap("longitude")]
                [Validation(Required=false)]
                public float? Longitude { get; set; }

            }

            [NameInMap("gmtLocation")]
            [Validation(Required=false)]
            public long? GmtLocation { get; set; }

            [NameInMap("gmtUpload")]
            [Validation(Required=false)]
            public long? GmtUpload { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
