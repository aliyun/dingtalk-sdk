// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UploadInvoiceResponseBodyResult Result { get; set; }
        public class UploadInvoiceResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<UploadInvoiceResponseBodyResultResults> Results { get; set; }
            public class UploadInvoiceResponseBodyResultResults : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("errCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("invoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

    }

}
