// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateInstanceOrderInfoRequest : TeaModel {
        [NameInMap("failReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        [NameInMap("outOrderNo")]
        [Validation(Required=false)]
        public string OutOrderNo { get; set; }

        [NameInMap("payerBank")]
        [Validation(Required=false)]
        public UpdateInstanceOrderInfoRequestPayerBank PayerBank { get; set; }
        public class UpdateInstanceOrderInfoRequestPayerBank : TeaModel {
            [NameInMap("cardNo")]
            [Validation(Required=false)]
            public string CardNo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
