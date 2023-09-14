// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class QueryConversationMessageForAIRequest : TeaModel {
        [NameInMap("openMsgIds")]
        [Validation(Required=false)]
        public List<string> OpenMsgIds { get; set; }

        [NameInMap("recentDays")]
        [Validation(Required=false)]
        public int? RecentDays { get; set; }

        [NameInMap("recentHours")]
        [Validation(Required=false)]
        public int? RecentHours { get; set; }

        [NameInMap("recentN")]
        [Validation(Required=false)]
        public int? RecentN { get; set; }

    }

}
