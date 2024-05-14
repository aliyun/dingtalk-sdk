// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenAnalyzeDataDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public int? DeptCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("noAlignObjectiveCount")]
        [Validation(Required=false)]
        public int? NoAlignObjectiveCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("noKeyActionCount")]
        [Validation(Required=false)]
        public int? NoKeyActionCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveAlignRate")]
        [Validation(Required=false)]
        public double? ObjectiveAlignRate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveNoSetCount")]
        [Validation(Required=false)]
        public int? ObjectiveNoSetCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveRiskCount")]
        [Validation(Required=false)]
        public int? ObjectiveRiskCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveSetRate")]
        [Validation(Required=false)]
        public double? ObjectiveSetRate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("onlyOneKeyResultCount")]
        [Validation(Required=false)]
        public int? OnlyOneKeyResultCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("onlyOneObjectiveCount")]
        [Validation(Required=false)]
        public int? OnlyOneObjectiveCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progressUpdateRateLast15Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast15Days { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progressUpdateRateLast30Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast30Days { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progressUpdateRateLast7Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast7Days { get; set; }

    }

}
