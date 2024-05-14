// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeOrderResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("batchTradeOrderVOs")]
        [Validation(Required=false)]
        public List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> BatchTradeOrderVOs { get; set; }
        public class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("alipayTransId")]
            [Validation(Required=false)]
            public string AlipayTransId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("failAmount")]
            [Validation(Required=false)]
            public string FailAmount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtSubmit")]
            [Validation(Required=false)]
            public string GmtSubmit { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("outBatchNo")]
            [Validation(Required=false)]
            public string OutBatchNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payerStaffId")]
            [Validation(Required=false)]
            public string PayerStaffId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("paymentAmount")]
            [Validation(Required=false)]
            public string PaymentAmount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("paymentCurrency")]
            [Validation(Required=false)]
            public string PaymentCurrency { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("successAmount")]
            [Validation(Required=false)]
            public string SuccessAmount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

    }

}
