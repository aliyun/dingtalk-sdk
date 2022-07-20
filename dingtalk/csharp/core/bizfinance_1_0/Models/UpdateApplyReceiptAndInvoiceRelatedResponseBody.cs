// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateApplyReceiptAndInvoiceRelatedResponseBody : TeaModel {
        /// <summary>
        /// 批量更新发票返回结果
        /// 
        /// </summary>
        [NameInMap("batchUpdateInvoiceResponse")]
        [Validation(Required=false)]
        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse BatchUpdateInvoiceResponse { get; set; }
        public class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse : TeaModel {
            [NameInMap("invoiceKeyVOList")]
            [Validation(Required=false)]
            public List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
            public class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList : TeaModel {
                public string InvoiceCode { get; set; }
                public string InvoiceNo { get; set; }
            }
        };

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
