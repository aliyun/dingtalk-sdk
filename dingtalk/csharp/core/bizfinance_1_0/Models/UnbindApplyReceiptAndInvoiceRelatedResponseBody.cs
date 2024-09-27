// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UnbindApplyReceiptAndInvoiceRelatedResponseBody : TeaModel {
        [NameInMap("batchUpdateInvoiceResponse")]
        [Validation(Required=false)]
        public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse BatchUpdateInvoiceResponse { get; set; }
        public class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse : TeaModel {
            [NameInMap("invoiceKeyVOList")]
            [Validation(Required=false)]
            public List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
            public class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("invoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

            }

        }

        [NameInMap("errorInvoiceKeyVOList")]
        [Validation(Required=false)]
        public List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> ErrorInvoiceKeyVOList { get; set; }
        public class UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList : TeaModel {
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
