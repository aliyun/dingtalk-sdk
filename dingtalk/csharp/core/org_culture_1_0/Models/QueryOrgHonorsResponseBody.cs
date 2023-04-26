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
                [NameInMap("honorDesc")]
                [Validation(Required=false)]
                public string HonorDesc { get; set; }

                [NameInMap("honorId")]
                [Validation(Required=false)]
                public long? HonorId { get; set; }

                [NameInMap("honorImgUrl")]
                [Validation(Required=false)]
                public string HonorImgUrl { get; set; }

                [NameInMap("honorName")]
                [Validation(Required=false)]
                public string HonorName { get; set; }

                [NameInMap("honorPendantImgUrl")]
                [Validation(Required=false)]
                public string HonorPendantImgUrl { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
