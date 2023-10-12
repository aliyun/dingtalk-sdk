// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class PreCreateGroupBillOrderRequest : TeaModel {
        [NameInMap("billItemList")]
        [Validation(Required=false)]
        public List<PreCreateGroupBillOrderRequestBillItemList> BillItemList { get; set; }
        public class PreCreateGroupBillOrderRequestBillItemList : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("payerUnionId")]
            [Validation(Required=false)]
            public string PayerUnionId { get; set; }

        }

        [NameInMap("extParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtParams { get; set; }

        [NameInMap("headCount")]
        [Validation(Required=false)]
        public long? HeadCount { get; set; }

        [NameInMap("isAverageAmount")]
        [Validation(Required=false)]
        public int? IsAverageAmount { get; set; }

        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("openCid")]
        [Validation(Required=false)]
        public string OpenCid { get; set; }

        [NameInMap("outBizNo")]
        [Validation(Required=false)]
        public string OutBizNo { get; set; }

        [NameInMap("payeeCorpId")]
        [Validation(Required=false)]
        public string PayeeCorpId { get; set; }

        [NameInMap("payeeUnionId")]
        [Validation(Required=false)]
        public string PayeeUnionId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

    }

}
