// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenObjectiveRuleDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("excludePopRuleView")]
        [Validation(Required=false)]
        public List<OpenObjectiveRuleScopeDTO> ExcludePopRuleView { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OKR / PBC</para>
        /// </summary>
        [NameInMap("objectiveCategory")]
        [Validation(Required=false)]
        public string ObjectiveCategory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6444f5e9a4261c6e699dxxxx</para>
        /// </summary>
        [NameInMap("objectiveRuleId")]
        [Validation(Required=false)]
        public string ObjectiveRuleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>规则</para>
        /// </summary>
        [NameInMap("objectiveRuleName")]
        [Validation(Required=false)]
        public string ObjectiveRuleName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("periods")]
        [Validation(Required=false)]
        public List<OpenObjectiveRulePeriodDTO> Periods { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("popRuleView")]
        [Validation(Required=false)]
        public List<OpenObjectiveRuleScopeDTO> PopRuleView { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("probationRule")]
        [Validation(Required=false)]
        public bool? ProbationRule { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ONLINE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
