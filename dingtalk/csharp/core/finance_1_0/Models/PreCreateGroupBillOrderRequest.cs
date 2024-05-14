// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class PreCreateGroupBillOrderRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("billItemList")]
        [Validation(Required=false)]
        public List<PreCreateGroupBillOrderRequestBillItemList> BillItemList { get; set; }
        public class PreCreateGroupBillOrderRequestBillItemList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payerUnionId")]
            [Validation(Required=false)]
            public string PayerUnionId { get; set; }

        }

        [NameInMap("extParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("headCount")]
        [Validation(Required=false)]
        public long? HeadCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isAverageAmount")]
        [Validation(Required=false)]
        public int? IsAverageAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("openCid")]
        [Validation(Required=false)]
        public string OpenCid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outBizNo")]
        [Validation(Required=false)]
        public string OutBizNo { get; set; }

        [NameInMap("payeeCorpId")]
        [Validation(Required=false)]
        public string PayeeCorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payeeUnionId")]
        [Validation(Required=false)]
        public string PayeeUnionId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

    }

}
