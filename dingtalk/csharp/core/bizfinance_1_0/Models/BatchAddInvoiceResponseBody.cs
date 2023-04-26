// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BatchAddInvoiceResponseBody : TeaModel {
        [NameInMap("errorResult")]
        [Validation(Required=false)]
        public List<BatchAddInvoiceResponseBodyErrorResult> ErrorResult { get; set; }
        public class BatchAddInvoiceResponseBodyErrorResult : TeaModel {
            [NameInMap("errorKey")]
            [Validation(Required=false)]
            public string ErrorKey { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<BatchAddInvoiceResponseBodySuccessResult> SuccessResult { get; set; }
        public class BatchAddInvoiceResponseBodySuccessResult : TeaModel {
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

        }

    }

}
