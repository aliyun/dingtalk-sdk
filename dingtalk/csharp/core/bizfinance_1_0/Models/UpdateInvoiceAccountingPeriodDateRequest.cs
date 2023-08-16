// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountingPeriodDateRequest : TeaModel {
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("invoiceFinanceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList> InvoiceFinanceInfoVOList { get; set; }
        public class UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList : TeaModel {
            [NameInMap("accountingPeriodData")]
            [Validation(Required=false)]
            public string AccountingPeriodData { get; set; }

            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

        }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
