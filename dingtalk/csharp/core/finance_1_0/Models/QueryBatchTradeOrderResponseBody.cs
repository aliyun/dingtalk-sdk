// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeOrderResponseBody : TeaModel {
        [NameInMap("batchTradeOrderVOs")]
        [Validation(Required=false)]
        public List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> BatchTradeOrderVOs { get; set; }
        public class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs : TeaModel {
            [NameInMap("alipayTransId")]
            [Validation(Required=false)]
            public string AlipayTransId { get; set; }

            [NameInMap("failAmount")]
            [Validation(Required=false)]
            public string FailAmount { get; set; }

            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            [NameInMap("gmtSubmit")]
            [Validation(Required=false)]
            public string GmtSubmit { get; set; }

            [NameInMap("outBatchNo")]
            [Validation(Required=false)]
            public string OutBatchNo { get; set; }

            [NameInMap("payerStaffId")]
            [Validation(Required=false)]
            public string PayerStaffId { get; set; }

            [NameInMap("paymentAmount")]
            [Validation(Required=false)]
            public string PaymentAmount { get; set; }

            [NameInMap("paymentCurrency")]
            [Validation(Required=false)]
            public string PaymentCurrency { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("successAmount")]
            [Validation(Required=false)]
            public string SuccessAmount { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

    }

}
