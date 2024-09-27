// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountPeriodResponseBody : TeaModel {
        [NameInMap("errorResult")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountPeriodResponseBodyErrorResult> ErrorResult { get; set; }
        public class UpdateInvoiceAccountPeriodResponseBodyErrorResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("errorKey")]
            [Validation(Required=false)]
            public string ErrorKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountPeriodResponseBodySuccessResult> SuccessResult { get; set; }
        public class UpdateInvoiceAccountPeriodResponseBodySuccessResult : TeaModel {
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

        }

    }

}
