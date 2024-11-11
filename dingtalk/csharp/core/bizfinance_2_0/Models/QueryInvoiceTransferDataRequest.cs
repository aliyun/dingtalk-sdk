// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryInvoiceTransferDataRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public QueryInvoiceTransferDataRequestBody Body { get; set; }
        public class QueryInvoiceTransferDataRequestBody : TeaModel {
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

        }

    }

}
