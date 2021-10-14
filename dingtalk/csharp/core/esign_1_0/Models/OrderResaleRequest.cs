// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class OrderResaleRequest : TeaModel {
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvAccessToken")]
        [Validation(Required=false)]
        public string DingIsvAccessToken { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("orderCreateTime")]
        [Validation(Required=false)]
        public long? OrderCreateTime { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        [NameInMap("serviceStartTime")]
        [Validation(Required=false)]
        public long? ServiceStartTime { get; set; }

        [NameInMap("serviceStopTime")]
        [Validation(Required=false)]
        public long? ServiceStopTime { get; set; }

    }

}
