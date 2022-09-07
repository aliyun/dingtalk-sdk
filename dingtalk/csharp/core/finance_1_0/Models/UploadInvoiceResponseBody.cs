// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceResponseBody : TeaModel {
        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UploadInvoiceResponseBodyResult Result { get; set; }
        public class UploadInvoiceResponseBodyResult : TeaModel {
            /// <summary>
            /// 上传结果
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<UploadInvoiceResponseBodyResultResults> Results { get; set; }
            public class UploadInvoiceResponseBodyResultResults : TeaModel {
                /// <summary>
                /// 业务错误码
                /// </summary>
                [NameInMap("errCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// 发票代码
                /// </summary>
                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// 发票号码
                /// </summary>
                [NameInMap("invoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// 失败原因
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// 是否成功
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

    }

}
