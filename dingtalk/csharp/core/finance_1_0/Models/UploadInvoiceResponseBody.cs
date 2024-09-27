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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<UploadInvoiceResponseBodyResultResults> Results { get; set; }
            public class UploadInvoiceResponseBodyResultResults : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20006</para>
                /// </summary>
                [NameInMap("errCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>033002000712</para>
                /// </summary>
                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20532643</para>
                /// </summary>
                [NameInMap("invoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>duplicateInvoice</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

    }

}
