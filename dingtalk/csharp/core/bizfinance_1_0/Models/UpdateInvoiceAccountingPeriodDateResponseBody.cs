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
            /// 失败发票数
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// 失败发票列表
            /// </summary>
            [NameInMap("failInvoices")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices> FailInvoices { get; set; }
            public class UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices : TeaModel {
                /// <summary>
                /// 错误码
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// 错误信息
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

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

            }

            /// <summary>
            /// 是否成功
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
