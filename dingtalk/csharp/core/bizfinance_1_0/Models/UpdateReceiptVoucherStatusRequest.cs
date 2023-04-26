// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateReceiptVoucherStatusRequest : TeaModel {
        [NameInMap("accountPeriod")]
        [Validation(Required=false)]
        public string AccountPeriod { get; set; }

        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("receiptId")]
        [Validation(Required=false)]
        public string ReceiptId { get; set; }

        [NameInMap("voucherCode")]
        [Validation(Required=false)]
        public string VoucherCode { get; set; }

        [NameInMap("voucherId")]
        [Validation(Required=false)]
        public string VoucherId { get; set; }

    }

}
