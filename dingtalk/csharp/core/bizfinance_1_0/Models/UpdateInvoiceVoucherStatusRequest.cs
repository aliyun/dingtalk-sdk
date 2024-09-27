// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceVoucherStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("accountantBookId")]
        [Validation(Required=false)]
        public string AccountantBookId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADD/DELETE</para>
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>11011023488</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("voucherId")]
        [Validation(Required=false)]
        public string VoucherId { get; set; }

    }

}
