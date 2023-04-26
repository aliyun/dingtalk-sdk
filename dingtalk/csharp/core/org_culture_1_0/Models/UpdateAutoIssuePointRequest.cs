// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class UpdateAutoIssuePointRequest : TeaModel {
        [NameInMap("pointAutoNum")]
        [Validation(Required=false)]
        public long? PointAutoNum { get; set; }

        [NameInMap("pointAutoState")]
        [Validation(Required=false)]
        public bool? PointAutoState { get; set; }

        [NameInMap("pointAutoTime")]
        [Validation(Required=false)]
        public long? PointAutoTime { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
