// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryOrgHonorsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryOrgHonorsResponseBodyResult Result { get; set; }
        public class QueryOrgHonorsResponseBodyResult : TeaModel {
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("openHonors")]
            [Validation(Required=false)]
            public List<QueryOrgHonorsResponseBodyResultOpenHonors> OpenHonors { get; set; }
            public class QueryOrgHonorsResponseBodyResultOpenHonors : TeaModel {
                public string HonorDesc { get; set; }
                public long? HonorId { get; set; }
                public string HonorImgUrl { get; set; }
                public string HonorName { get; set; }
                public string HonorPendantImgUrl { get; set; }
            }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
