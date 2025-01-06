// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BatchQueryOrgInvoiceUrlResponseBody : TeaModel {
        [NameInMap("failInvoiceList")]
        [Validation(Required=false)]
        public List<BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList> FailInvoiceList { get; set; }
        public class BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList : TeaModel {
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

        [NameInMap("orgInvoiceUrlList")]
        [Validation(Required=false)]
        public List<BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList> OrgInvoiceUrlList { get; set; }
        public class BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList : TeaModel {
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            [NameInMap("ofdUrl")]
            [Validation(Required=false)]
            public string OfdUrl { get; set; }

            [NameInMap("originFileType")]
            [Validation(Required=false)]
            public string OriginFileType { get; set; }

            [NameInMap("originFileUrl")]
            [Validation(Required=false)]
            public string OriginFileUrl { get; set; }

            [NameInMap("pdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            [NameInMap("xmlUrl")]
            [Validation(Required=false)]
            public string XmlUrl { get; set; }

        }

    }

}
