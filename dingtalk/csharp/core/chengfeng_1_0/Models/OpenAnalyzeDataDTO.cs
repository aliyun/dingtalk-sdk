// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenAnalyzeDataDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public int? DeptCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("noAlignObjectiveCount")]
        [Validation(Required=false)]
        public int? NoAlignObjectiveCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("noKeyActionCount")]
        [Validation(Required=false)]
        public int? NoKeyActionCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33.2</para>
        /// </summary>
        [NameInMap("objectiveAlignRate")]
        [Validation(Required=false)]
        public double? ObjectiveAlignRate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("objectiveNoSetCount")]
        [Validation(Required=false)]
        public int? ObjectiveNoSetCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("objectiveRiskCount")]
        [Validation(Required=false)]
        public int? ObjectiveRiskCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33.3</para>
        /// </summary>
        [NameInMap("objectiveSetRate")]
        [Validation(Required=false)]
        public double? ObjectiveSetRate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("onlyOneKeyResultCount")]
        [Validation(Required=false)]
        public int? OnlyOneKeyResultCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("onlyOneObjectiveCount")]
        [Validation(Required=false)]
        public int? OnlyOneObjectiveCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.3</para>
        /// </summary>
        [NameInMap("progressUpdateRateLast15Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast15Days { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33.11</para>
        /// </summary>
        [NameInMap("progressUpdateRateLast30Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast30Days { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33.4</para>
        /// </summary>
        [NameInMap("progressUpdateRateLast7Days")]
        [Validation(Required=false)]
        public double? ProgressUpdateRateLast7Days { get; set; }

    }

}
