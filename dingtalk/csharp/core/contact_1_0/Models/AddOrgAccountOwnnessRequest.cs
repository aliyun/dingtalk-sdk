// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class AddOrgAccountOwnnessRequest : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ownenssType")]
        [Validation(Required=false)]
        public long? OwnenssType { get; set; }

        [NameInMap("ownnessId")]
        [Validation(Required=false)]
        public long? OwnnessId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public float? StartTime { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
