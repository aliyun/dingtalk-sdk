// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateInvoiceUrlResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateInvoiceUrlResponseBodyResult Result { get; set; }
        public class UpdateInvoiceUrlResponseBodyResult : TeaModel {
            [NameInMap("failInvoiceList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceUrlResponseBodyResultFailInvoiceList> FailInvoiceList { get; set; }
            public class UpdateInvoiceUrlResponseBodyResultFailInvoiceList : TeaModel {
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

            [NameInMap("isAllSuccess")]
            [Validation(Required=false)]
            public string IsAllSuccess { get; set; }

        }

    }

}
