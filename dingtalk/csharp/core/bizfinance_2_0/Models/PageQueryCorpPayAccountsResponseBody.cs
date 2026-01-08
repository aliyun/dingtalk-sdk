// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class PageQueryCorpPayAccountsResponseBody : TeaModel {
        [NameInMap("accounts")]
        [Validation(Required=false)]
        public List<PageQueryCorpPayAccountsResponseBodyAccounts> Accounts { get; set; }
        public class PageQueryCorpPayAccountsResponseBodyAccounts : TeaModel {
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

            [NameInMap("creatorUid")]
            [Validation(Required=false)]
            public long? CreatorUid { get; set; }

            [NameInMap("hasSignReceipt")]
            [Validation(Required=false)]
            public bool? HasSignReceipt { get; set; }

        }

    }

}
