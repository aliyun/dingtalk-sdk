// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalUserObjectiveListRequest : TeaModel {
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        [NameInMap("objectiveRuleId")]
        [Validation(Required=false)]
        public string ObjectiveRuleId { get; set; }

        [NameInMap("periodIds")]
        [Validation(Required=false)]
        public List<string> PeriodIds { get; set; }

    }

}
