// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class LinkCommonInvokeRequest : TeaModel {
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("invokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
