// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountingPeriodDateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("invoiceFinanceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList> InvoiceFinanceInfoVOList { get; set; }
        public class UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-02-03</para>
            /// </summary>
            [NameInMap("accountingPeriodData")]
            [Validation(Required=false)]
            public string AccountingPeriodData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2202020</para>
            /// </summary>
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>220200200</para>
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
