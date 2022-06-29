// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BatchAddInvoiceResponseBody : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchAddInvoiceResponseBodyResult> Result { get; set; }
        public class BatchAddInvoiceResponseBodyResult : TeaModel {
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

    }

}
