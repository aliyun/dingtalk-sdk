// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateFileStatusRequest : TeaModel {
        [NameInMap("requestIds")]
        [Validation(Required=false)]
        public List<string> RequestIds { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
