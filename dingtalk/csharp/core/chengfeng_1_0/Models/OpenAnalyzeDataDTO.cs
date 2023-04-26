// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenAnalyzeDataDTO : TeaModel {
        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public int? DeptCount { get; set; }

        [NameInMap("noAlignObjectiveCount")]
        [Validation(Required=false)]
        public int? NoAlignObjectiveCount { get; set; }

        [NameInMap("noKeyActionCount")]
        [Validation(Required=false)]
        public int? NoKeyActionCount { get; set; }

        [NameInMap("objectiveAlignRate")]
        [Validation(Required=false)]
        public double? ObjectiveAlignRate { get; set; }

        [NameInMap("objectiveNoSetCount")]
        [Validation(Required=false)]
        public int? ObjectiveNoSetCount { get; set; }

        [NameInMap("objectiveRiskCount")]
        [Validation(Required=false)]
        public int? ObjectiveRiskCount { get; set; }

        [NameInMap("objectiveSetRate")]
        [Validation(Required=false)]
        public double? ObjectiveSetRate { get; set; }

        [NameInMap("onlyOneKeyResultCount")]
        [Validation(Required=false)]
        public int? OnlyOneKeyResultCount { get; set; }

        [NameInMap("onlyOneObjectiveCount")]
        [Validation(Required=false)]
        public int? OnlyOneObjectiveCount { get; set; }

        [NameInMap("progressUpdateRateLast15Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast15Days { get; set; }

        [NameInMap("progressUpdateRateLast30Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast30Days { get; set; }

        [NameInMap("progressUpdateRateLast7Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast7Days { get; set; }

    }

}
