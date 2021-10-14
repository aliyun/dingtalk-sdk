// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeOrderResponseBody : TeaModel {
        /// <summary>
        /// 批量交易订单VO
        /// </summary>
        [NameInMap("batchTradeOrderVOs")]
        [Validation(Required=false)]
        public List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> BatchTradeOrderVOs { get; set; }
        public class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs : TeaModel {
            /// <summary>
            /// 批次号
            /// </summary>
            [NameInMap("outBatchNo")]
            [Validation(Required=false)]
            public string OutBatchNo { get; set; }

            /// <summary>
            /// 支付宝批次订单号
            /// </summary>
            [NameInMap("alipayTransId")]
            [Validation(Required=false)]
            public string AlipayTransId { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 成功笔数
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// 成功金额（元）
            /// </summary>
            [NameInMap("successAmount")]
            [Validation(Required=false)]
            public string SuccessAmount { get; set; }

            /// <summary>
            /// 失败笔数
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// 明细处理失败的支付汇总金额
            /// </summary>
            [NameInMap("failAmount")]
            [Validation(Required=false)]
            public string FailAmount { get; set; }

            /// <summary>
            /// 批次的总金额（元）
            /// </summary>
            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

            /// <summary>
            /// 批次完成交易时间
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// 批次受理交易时间
            /// </summary>
            [NameInMap("gmtSubmit")]
            [Validation(Required=false)]
            public string GmtSubmit { get; set; }

            /// <summary>
            /// 失败原因
            /// </summary>
            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// 付款方需要支付的金额（元）
            /// </summary>
            [NameInMap("paymentAmount")]
            [Validation(Required=false)]
            public string PaymentAmount { get; set; }

            /// <summary>
            /// 支付币种
            /// </summary>
            [NameInMap("paymentCurrency")]
            [Validation(Required=false)]
            public string PaymentCurrency { get; set; }

            /// <summary>
            /// 付款人staffId
            /// </summary>
            [NameInMap("payerStaffId")]
            [Validation(Required=false)]
            public string PayerStaffId { get; set; }

        }

    }

}
