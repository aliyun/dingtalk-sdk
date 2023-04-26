// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreateBatchTradeOrderRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("accountNo")]
        [Validation(Required=false)]
        public string AccountNo { get; set; }

        [NameInMap("batchRemark")]
        [Validation(Required=false)]
        public string BatchRemark { get; set; }

        [NameInMap("batchTradeDetails")]
        [Validation(Required=false)]
        public List<CreateBatchTradeOrderRequestBatchTradeDetails> BatchTradeDetails { get; set; }
        public class CreateBatchTradeOrderRequestBatchTradeDetails : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("payeeAccountName")]
            [Validation(Required=false)]
            public string PayeeAccountName { get; set; }

            [NameInMap("payeeAccountNo")]
            [Validation(Required=false)]
            public string PayeeAccountNo { get; set; }

            [NameInMap("payeeAccountType")]
            [Validation(Required=false)]
            public string PayeeAccountType { get; set; }

            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public long? SerialNo { get; set; }

        }

        [NameInMap("outBatchNo")]
        [Validation(Required=false)]
        public string OutBatchNo { get; set; }

        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("tradeTitle")]
        [Validation(Required=false)]
        public string TradeTitle { get; set; }

    }

}
