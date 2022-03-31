// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryUserHonorsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserHonorsResponseBodyResult Result { get; set; }
        public class QueryUserHonorsResponseBodyResult : TeaModel {
            [NameInMap("honors")]
            [Validation(Required=false)]
            public List<QueryUserHonorsResponseBodyResultHonors> Honors { get; set; }
            public class QueryUserHonorsResponseBodyResultHonors : TeaModel {
                public long? ExpirationTime { get; set; }
                public List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> GrantHistory { get; set; }
                public class QueryUserHonorsResponseBodyResultHonorsGrantHistory : TeaModel {
                    public long? GrantTime { get; set; }
                    public string SenderUserid { get; set; }
                }
                public string HonorDesc { get; set; }
                public string HonorId { get; set; }
                public string HonorName { get; set; }
            }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
