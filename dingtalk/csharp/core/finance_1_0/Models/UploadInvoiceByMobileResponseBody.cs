// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceByMobileResponseBody : TeaModel {
        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UploadInvoiceByMobileResponseBodyResult Result { get; set; }
        public class UploadInvoiceByMobileResponseBodyResult : TeaModel {
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<UploadInvoiceByMobileResponseBodyResultResults> Results { get; set; }
            public class UploadInvoiceByMobileResponseBodyResultResults : TeaModel {
                public string InvoiceCode { get; set; }
                public string InvoiceNo { get; set; }
                public bool? Success { get; set; }
                public string Reason { get; set; }
                public string ErrCode { get; set; }
            }
        };

    }

}
