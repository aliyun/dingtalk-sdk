// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryBranchResponseBody : TeaModel {
        [NameInMap("supportSubBanks")]
        [Validation(Required=false)]
        public List<QueryBranchResponseBodySupportSubBanks> SupportSubBanks { get; set; }
        public class QueryBranchResponseBodySupportSubBanks : TeaModel {
            [NameInMap("branchCode")]
            [Validation(Required=false)]
            public string BranchCode { get; set; }

            [NameInMap("branchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

        }

    }

}
