// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceByAuthResponseBody : TeaModel {
        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UploadInvoiceByAuthResponseBodyResult Result { get; set; }
        public class UploadInvoiceByAuthResponseBodyResult : TeaModel {
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<UploadInvoiceByAuthResponseBodyResultResults> Results { get; set; }
            public class UploadInvoiceByAuthResponseBodyResultResults : TeaModel {
                public string ErrCode { get; set; }
                public string InvoiceCode { get; set; }
                public string InvoiceNo { get; set; }
                public string Reason { get; set; }
                public bool? Success { get; set; }
            }
        };

    }

}
