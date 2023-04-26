// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryRegisterOrderResponseBody : TeaModel {
        [NameInMap("failReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        [NameInMap("gmtAudit")]
        [Validation(Required=false)]
        public string GmtAudit { get; set; }

        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        [NameInMap("subInstName")]
        [Validation(Required=false)]
        public string SubInstName { get; set; }

    }

}
