// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfWeightRequest : TeaModel {
        [NameInMap("weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
