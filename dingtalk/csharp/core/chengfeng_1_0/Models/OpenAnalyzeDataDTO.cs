// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenAnalyzeDataDTO : TeaModel {
        /// <summary>
        /// 部门总人数
        /// </summary>
        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public int? DeptCount { get; set; }

        /// <summary>
        /// 无对齐O人数
        /// </summary>
        [NameInMap("noAlignObjectiveCount")]
        [Validation(Required=false)]
        public int? NoAlignObjectiveCount { get; set; }

        /// <summary>
        /// 未关联关键行动人数
        /// </summary>
        [NameInMap("noKeyActionCount")]
        [Validation(Required=false)]
        public int? NoKeyActionCount { get; set; }

        /// <summary>
        /// 目标对齐率
        /// </summary>
        [NameInMap("objectiveAlignRate")]
        [Validation(Required=false)]
        public double? ObjectiveAlignRate { get; set; }

        /// <summary>
        /// 目标未设定人数
        /// </summary>
        [NameInMap("objectiveNoSetCount")]
        [Validation(Required=false)]
        public int? ObjectiveNoSetCount { get; set; }

        /// <summary>
        /// 有风险O的人数
        /// </summary>
        [NameInMap("objectiveRiskCount")]
        [Validation(Required=false)]
        public int? ObjectiveRiskCount { get; set; }

        /// <summary>
        /// 目标设定率
        /// </summary>
        [NameInMap("objectiveSetRate")]
        [Validation(Required=false)]
        public double? ObjectiveSetRate { get; set; }

        /// <summary>
        /// 只有1个KR的人数
        /// </summary>
        [NameInMap("onlyOneKeyResultCount")]
        [Validation(Required=false)]
        public int? OnlyOneKeyResultCount { get; set; }

        /// <summary>
        /// 只有1个O的人数
        /// </summary>
        [NameInMap("onlyOneObjectiveCount")]
        [Validation(Required=false)]
        public int? OnlyOneObjectiveCount { get; set; }

        /// <summary>
        /// 近15天进展更新率
        /// </summary>
        [NameInMap("progressUpdateRateLast15Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast15Days { get; set; }

        /// <summary>
        /// 近30天进展更新率
        /// </summary>
        [NameInMap("progressUpdateRateLast30Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast30Days { get; set; }

        /// <summary>
        /// 近7天进展更新率
        /// </summary>
        [NameInMap("progressUpdateRateLast7Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast7Days { get; set; }

    }

}
