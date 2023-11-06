// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class SignEnterpriseAccountRequest : TeaModel {
        [NameInMap("bankCardNo")]
        [Validation(Required=false)]
        public string BankCardNo { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("signOperateType")]
        [Validation(Required=false)]
        public string SignOperateType { get; set; }

    }

}
