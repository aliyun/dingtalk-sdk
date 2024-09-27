// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreateBatchTradeOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021070712440326300185114</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13****9</para>
        /// </summary>
        [NameInMap("accountNo")]
        [Validation(Required=false)]
        public string AccountNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("batchRemark")]
        [Validation(Required=false)]
        public string BatchRemark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("batchTradeDetails")]
        [Validation(Required=false)]
        public List<CreateBatchTradeOrderRequestBatchTradeDetails> BatchTradeDetails { get; set; }
        public class CreateBatchTradeOrderRequestBatchTradeDetails : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>工资</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("payeeAccountName")]
            [Validation(Required=false)]
            public string PayeeAccountName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13000000000</para>
            /// </summary>
            [NameInMap("payeeAccountNo")]
            [Validation(Required=false)]
            public string PayeeAccountNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("payeeAccountType")]
            [Validation(Required=false)]
            public string PayeeAccountType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public long? SerialNo { get; set; }

        }

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
        /// <para>8476212471</para>
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.00</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>工资</para>
        /// </summary>
        [NameInMap("tradeTitle")]
        [Validation(Required=false)]
        public string TradeTitle { get; set; }

    }

}
