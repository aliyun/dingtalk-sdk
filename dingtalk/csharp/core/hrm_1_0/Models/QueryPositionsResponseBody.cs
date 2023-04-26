// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryPositionsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryPositionsResponseBodyList> List { get; set; }
        public class QueryPositionsResponseBodyList : TeaModel {
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("positionCategoryId")]
            [Validation(Required=false)]
            public string PositionCategoryId { get; set; }

            [NameInMap("positionDes")]
            [Validation(Required=false)]
            public string PositionDes { get; set; }

            [NameInMap("positionId")]
            [Validation(Required=false)]
            public string PositionId { get; set; }

            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            [NameInMap("rankIdList")]
            [Validation(Required=false)]
            public List<string> RankIdList { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
