// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobRanksRequest : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        [NameInMap("rankCategoryId")]
        [Validation(Required=false)]
        public string RankCategoryId { get; set; }

        [NameInMap("rankCode")]
        [Validation(Required=false)]
        public string RankCode { get; set; }

        [NameInMap("rankName")]
        [Validation(Required=false)]
        public string RankName { get; set; }

    }

}
