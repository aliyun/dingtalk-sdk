// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UnbindApplyReceiptAndInvoiceRelatedRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("invoiceKeyVOList")]
        [Validation(Required=false)]
        public List<UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
        public class UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList : TeaModel {
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

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
