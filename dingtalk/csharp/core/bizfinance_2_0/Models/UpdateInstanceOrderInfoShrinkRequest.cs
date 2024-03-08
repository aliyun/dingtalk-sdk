// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateInstanceOrderInfoShrinkRequest : TeaModel {
        [NameInMap("failReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("outOrderNo")]
        [Validation(Required=false)]
        public string OutOrderNo { get; set; }

        [NameInMap("payerBank")]
        [Validation(Required=false)]
        public string PayerBankShrink { get; set; }

        [NameInMap("paymentTime")]
        [Validation(Required=false)]
        public long? PaymentTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
