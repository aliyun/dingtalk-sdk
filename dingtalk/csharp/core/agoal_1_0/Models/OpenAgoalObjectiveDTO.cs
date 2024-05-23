// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalObjectiveDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("executor")]
        [Validation(Required=false)]
        public OpenAgoalUserDTO Executor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("keyResults")]
        [Validation(Required=false)]
        public List<OpenAgoalKeyResultDTO> KeyResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveRule")]
        [Validation(Required=false)]
        public OpenOrgObjectiveRuleDTO ObjectiveRule { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public OpenObjectiveRulePeriodDTO Period { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("teams")]
        [Validation(Required=false)]
        public List<OpenAgoalTeamDTO> Teams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public double? Weight { get; set; }

    }

}
