// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("batchTradeOrderVOs")]
        [Validation(Required=false)]
        public List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> BatchTradeOrderVOs { get; set; }
        public class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021090102102122200002121</para>
            /// </summary>
            [NameInMap("alipayTransId")]
            [Validation(Required=false)]
            public string AlipayTransId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failAmount")]
            [Validation(Required=false)]
            public string FailAmount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>收款人不存在</para>
            /// </summary>
            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-01 12:00:00</para>
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-01 11:00:00</para>
            /// </summary>
            [NameInMap("gmtSubmit")]
            [Validation(Required=false)]
            public string GmtSubmit { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20210901001</para>
            /// </summary>
            [NameInMap("outBatchNo")]
            [Validation(Required=false)]
            public string OutBatchNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213654465</para>
            /// </summary>
            [NameInMap("payerStaffId")]
            [Validation(Required=false)]
            public string PayerStaffId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("paymentAmount")]
            [Validation(Required=false)]
            public string PaymentAmount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("paymentCurrency")]
            [Validation(Required=false)]
            public string PaymentCurrency { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("successAmount")]
            [Validation(Required=false)]
            public string SuccessAmount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

    }

}
