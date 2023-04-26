// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueueNotifyRequest : TeaModel {
        [NameInMap("estimateWaitMin")]
        [Validation(Required=false)]
        public long? EstimateWaitMin { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("queuePlace")]
        [Validation(Required=false)]
        public long? QueuePlace { get; set; }

        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        [NameInMap("targetChannel")]
        [Validation(Required=false)]
        public string TargetChannel { get; set; }

        [NameInMap("tips")]
        [Validation(Required=false)]
        public string Tips { get; set; }

        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}
