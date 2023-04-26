// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobRanksResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryJobRanksResponseBodyList> List { get; set; }
        public class QueryJobRanksResponseBodyList : TeaModel {
            [NameInMap("maxJobGrade")]
            [Validation(Required=false)]
            public int? MaxJobGrade { get; set; }

            [NameInMap("minJobGrade")]
            [Validation(Required=false)]
            public int? MinJobGrade { get; set; }

            [NameInMap("rankCategoryId")]
            [Validation(Required=false)]
            public string RankCategoryId { get; set; }

            [NameInMap("rankCode")]
            [Validation(Required=false)]
            public string RankCode { get; set; }

            [NameInMap("rankDescription")]
            [Validation(Required=false)]
            public string RankDescription { get; set; }

            [NameInMap("rankId")]
            [Validation(Required=false)]
            public string RankId { get; set; }

            [NameInMap("rankName")]
            [Validation(Required=false)]
            public string RankName { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
