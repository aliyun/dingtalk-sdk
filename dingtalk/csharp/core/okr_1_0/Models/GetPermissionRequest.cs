// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetPermissionRequest : TeaModel {
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("withKr")]
        [Validation(Required=false)]
        public bool? WithKr { get; set; }

        [NameInMap("withObjective")]
        [Validation(Required=false)]
        public bool? WithObjective { get; set; }

    }

}
