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
                [NameInMap("expirationTime")]
                [Validation(Required=false)]
                public long? ExpirationTime { get; set; }

                [NameInMap("grantHistory")]
                [Validation(Required=false)]
                public List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> GrantHistory { get; set; }
                public class QueryUserHonorsResponseBodyResultHonorsGrantHistory : TeaModel {
                    [NameInMap("grantTime")]
                    [Validation(Required=false)]
                    public long? GrantTime { get; set; }

                    [NameInMap("senderUserid")]
                    [Validation(Required=false)]
                    public string SenderUserid { get; set; }

                }

                [NameInMap("honorDesc")]
                [Validation(Required=false)]
                public string HonorDesc { get; set; }

                [NameInMap("honorId")]
                [Validation(Required=false)]
                public string HonorId { get; set; }

                [NameInMap("honorName")]
                [Validation(Required=false)]
                public string HonorName { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
