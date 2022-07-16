// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateApplyReceiptAndInvoiceRelatedResponseBody : TeaModel {
        /// <summary>
        /// 失败发票列表list
        /// </summary>
        [NameInMap("invoiceKeyVOList")]
        [Validation(Required=false)]
        public List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
        public class UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList : TeaModel {
            /// <summary>
            /// 失败发票列表list
            /// </summary>
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// 失败发票列表list
            /// </summary>
            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

        }

    }

}
