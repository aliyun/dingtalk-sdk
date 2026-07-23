// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ExclusiveBannerRequest : TeaModel {
        [NameInMap("allOrg")]
        [Validation(Required=false)]
        public bool? AllOrg { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("imageMediaId")]
        [Validation(Required=false)]
        public string ImageMediaId { get; set; }

        [NameInMap("openLink")]
        [Validation(Required=false)]
        public string OpenLink { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
