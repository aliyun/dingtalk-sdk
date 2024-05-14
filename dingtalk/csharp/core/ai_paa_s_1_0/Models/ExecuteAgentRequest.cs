// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class ExecuteAgentRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("agentCode")]
        [Validation(Required=false)]
        public string AgentCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public ExecuteAgentRequestInputs Inputs { get; set; }
        public class ExecuteAgentRequestInputs : TeaModel {
            [NameInMap("cardData")]
            [Validation(Required=false)]
            public object CardData { get; set; }

            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            [NameInMap("input")]
            [Validation(Required=false)]
            public string Input { get; set; }

        }

        [NameInMap("scenarioCode")]
        [Validation(Required=false)]
        public string ScenarioCode { get; set; }

        [NameInMap("scenarioInstanceId")]
        [Validation(Required=false)]
        public string ScenarioInstanceId { get; set; }

        [NameInMap("skillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

    }

}
