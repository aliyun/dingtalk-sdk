// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateInvoiceUrlRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateInvoiceUrlRequestBody Body { get; set; }
        public class UpdateInvoiceUrlRequestBody : TeaModel {
            [NameInMap("companyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("urlList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceUrlRequestBodyUrlList> UrlList { get; set; }
            public class UpdateInvoiceUrlRequestBodyUrlList : TeaModel {
                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("invoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("ofdUrl")]
                [Validation(Required=false)]
                public string OfdUrl { get; set; }

                [NameInMap("pdfUrl")]
                [Validation(Required=false)]
                public string PdfUrl { get; set; }

                [NameInMap("xmlUrl")]
                [Validation(Required=false)]
                public string XmlUrl { get; set; }

            }

        }

    }

}
