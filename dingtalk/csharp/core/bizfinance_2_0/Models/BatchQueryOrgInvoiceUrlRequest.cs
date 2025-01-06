// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BatchQueryOrgInvoiceUrlRequest : TeaModel {
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("invoiceKeyVOList")]
        [Validation(Required=false)]
        public List<BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
        public class BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList : TeaModel {
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

        }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
