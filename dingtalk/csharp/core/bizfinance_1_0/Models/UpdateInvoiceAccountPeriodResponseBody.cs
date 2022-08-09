// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountPeriodResponseBody : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorResult")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountPeriodResponseBodyErrorResult> ErrorResult { get; set; }
        public class UpdateInvoiceAccountPeriodResponseBodyErrorResult : TeaModel {
            /// <summary>
            /// 错误数据的key
            /// </summary>
            [NameInMap("errorKey")]
            [Validation(Required=false)]
            public string ErrorKey { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

        /// <summary>
        /// 成功信息
        /// </summary>
        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountPeriodResponseBodySuccessResult> SuccessResult { get; set; }
        public class UpdateInvoiceAccountPeriodResponseBodySuccessResult : TeaModel {
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

    }

}
