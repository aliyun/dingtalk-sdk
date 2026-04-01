// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryBranchRequest : TeaModel {
        [NameInMap("bankName")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

    }

}
