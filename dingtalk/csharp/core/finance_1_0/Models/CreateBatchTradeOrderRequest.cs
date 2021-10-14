// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreateBatchTradeOrderRequest : TeaModel {
        /// <summary>
        /// 付款账号唯一id
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 付款账号(注意：用户上送的是脱敏数据)
        /// </summary>
        [NameInMap("accountNo")]
        [Validation(Required=false)]
        public string AccountNo { get; set; }

        /// <summary>
        /// 批次备注
        /// </summary>
        [NameInMap("batchRemark")]
        [Validation(Required=false)]
        public string BatchRemark { get; set; }

        /// <summary>
        /// 交易明细列表
        /// </summary>
        [NameInMap("batchTradeDetails")]
        [Validation(Required=false)]
        public List<CreateBatchTradeOrderRequestBatchTradeDetails> BatchTradeDetails { get; set; }
        public class CreateBatchTradeOrderRequestBatchTradeDetails : TeaModel {
            /// <summary>
            /// 序号（必填）
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public long? SerialNo { get; set; }

            /// <summary>
            /// 金额（必填，单位：元）
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 收款方户名（必填）
            /// </summary>
            [NameInMap("payeeAccountName")]
            [Validation(Required=false)]
            public string PayeeAccountName { get; set; }

            /// <summary>
            /// 收款方账号（必填）
            /// </summary>
            [NameInMap("payeeAccountNo")]
            [Validation(Required=false)]
            public string PayeeAccountNo { get; set; }

            /// <summary>
            /// 收款方账号类型（必填）
            /// </summary>
            [NameInMap("payeeAccountType")]
            [Validation(Required=false)]
            public string PayeeAccountType { get; set; }

            /// <summary>
            /// 备注（选填）
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

        /// <summary>
        /// 企业corpId
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// Isv corpId
        /// </summary>
        [NameInMap("isvCorpId")]
        [Validation(Required=false)]
        public string IsvCorpId { get; set; }

        /// <summary>
        /// 外部商户批次号
        /// </summary>
        [NameInMap("outBatchNo")]
        [Validation(Required=false)]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 员工staffId
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// ISV/企业自建应用suiteId
        /// </summary>
        [NameInMap("suiteId")]
        [Validation(Required=false)]
        public string SuiteId { get; set; }

        /// <summary>
        /// 总金额（必填，单位：元）
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总笔数（必填）
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 交易抬头
        /// </summary>
        [NameInMap("tradeTitle")]
        [Validation(Required=false)]
        public string TradeTitle { get; set; }

    }

}
