// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceByAuthResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UploadInvoiceByAuthResponseBodyResult Result { get; set; }
        public class UploadInvoiceByAuthResponseBodyResult : TeaModel {
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<UploadInvoiceByAuthResponseBodyResultResults> Results { get; set; }
            public class UploadInvoiceByAuthResponseBodyResultResults : TeaModel {
                [NameInMap("errCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("invoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

    }

}
