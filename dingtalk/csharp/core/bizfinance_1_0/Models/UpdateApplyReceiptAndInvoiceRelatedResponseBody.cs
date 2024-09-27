// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateApplyReceiptAndInvoiceRelatedResponseBody : TeaModel {
        [NameInMap("batchUpdateInvoiceResponse")]
        [Validation(Required=false)]
        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse BatchUpdateInvoiceResponse { get; set; }
        public class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse : TeaModel {
            [NameInMap("invoiceKeyVOList")]
            [Validation(Required=false)]
            public List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
            public class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList : TeaModel {
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
        public List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> ErrorInvoiceKeyVOList { get; set; }
        public class UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList : TeaModel {
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
