// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryBankResponseBody : TeaModel {
        [NameInMap("supportBanks")]
        [Validation(Required=false)]
        public List<QueryBankResponseBodySupportBanks> SupportBanks { get; set; }
        public class QueryBankResponseBodySupportBanks : TeaModel {
            [NameInMap("bankAbbr")]
            [Validation(Required=false)]
            public string BankAbbr { get; set; }

            [NameInMap("bankFirstPinYin")]
            [Validation(Required=false)]
            public string BankFirstPinYin { get; set; }

            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

        }

    }

}
