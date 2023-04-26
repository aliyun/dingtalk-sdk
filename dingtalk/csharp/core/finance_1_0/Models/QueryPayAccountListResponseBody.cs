// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryPayAccountListResponseBody : TeaModel {
        [NameInMap("payAccountVOList")]
        [Validation(Required=false)]
        public List<QueryPayAccountListResponseBodyPayAccountVOList> PayAccountVOList { get; set; }
        public class QueryPayAccountListResponseBodyPayAccountVOList : TeaModel {
            [NameInMap("accountClass")]
            [Validation(Required=false)]
            public string AccountClass { get; set; }

            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("accountNo")]
            [Validation(Required=false)]
            public string AccountNo { get; set; }

            [NameInMap("accountRemark")]
            [Validation(Required=false)]
            public string AccountRemark { get; set; }

            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

    }

}
