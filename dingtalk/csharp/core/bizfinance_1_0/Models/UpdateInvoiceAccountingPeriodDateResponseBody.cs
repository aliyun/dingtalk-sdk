// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountingPeriodDateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateInvoiceAccountingPeriodDateResponseBodyResult Result { get; set; }
        public class UpdateInvoiceAccountingPeriodDateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            [NameInMap("failInvoices")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices> FailInvoices { get; set; }
            public class UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50001</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>invoice not exist</para>
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1231231231</para>
                /// </summary>
                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1231231231</para>
                /// </summary>
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
