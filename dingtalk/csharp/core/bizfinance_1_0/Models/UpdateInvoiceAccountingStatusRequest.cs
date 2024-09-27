// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountingStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("invoiceFinanceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList> InvoiceFinanceInfoVOList { get; set; }
        public class UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>in_account</para>
            /// </summary>
            [NameInMap("accountingStatus")]
            [Validation(Required=false)]
            public string AccountingStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022002022</para>
            /// </summary>
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20022</para>
            /// </summary>
            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VAT_DIGITAL_NORMAL</para>
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
