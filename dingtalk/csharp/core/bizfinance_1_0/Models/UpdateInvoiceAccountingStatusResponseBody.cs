// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountingStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateInvoiceAccountingStatusResponseBodyResult Result { get; set; }
        public class UpdateInvoiceAccountingStatusResponseBodyResult : TeaModel {
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            [NameInMap("failInvoices")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices> FailInvoices { get; set; }
            public class UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices : TeaModel {
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

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

}
