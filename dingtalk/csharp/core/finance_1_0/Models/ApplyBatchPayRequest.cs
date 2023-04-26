// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ApplyBatchPayRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("passBackParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> PassBackParams { get; set; }

        [NameInMap("payTerminal")]
        [Validation(Required=false)]
        public string PayTerminal { get; set; }

        [NameInMap("returnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        [NameInMap("transAmount")]
        [Validation(Required=false)]
        public string TransAmount { get; set; }

        [NameInMap("transExpireTime")]
        [Validation(Required=false)]
        public string TransExpireTime { get; set; }

    }

}
