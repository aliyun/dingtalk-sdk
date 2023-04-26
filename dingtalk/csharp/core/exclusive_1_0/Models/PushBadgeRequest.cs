// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class PushBadgeRequest : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("badgeItems")]
        [Validation(Required=false)]
        public List<PushBadgeRequestBadgeItems> BadgeItems { get; set; }
        public class PushBadgeRequestBadgeItems : TeaModel {
            [NameInMap("pushValue")]
            [Validation(Required=false)]
            public string PushValue { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("pushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

    }

}
