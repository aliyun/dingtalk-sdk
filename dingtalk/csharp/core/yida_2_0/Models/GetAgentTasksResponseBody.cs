// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetAgentTasksResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<GetAgentTasksResponseBodyValues> Values { get; set; }
        public class GetAgentTasksResponseBodyValues : TeaModel {
            [NameInMap("agentCategory")]
            [Validation(Required=false)]
            public string AgentCategory { get; set; }

            [NameInMap("agentCreateGMT")]
            [Validation(Required=false)]
            public string AgentCreateGMT { get; set; }

            [NameInMap("agentEndGMT")]
            [Validation(Required=false)]
            public string AgentEndGMT { get; set; }

            [NameInMap("agentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("agentRangeType")]
            [Validation(Required=false)]
            public string AgentRangeType { get; set; }

            [NameInMap("agentRangeValue")]
            [Validation(Required=false)]
            public string AgentRangeValue { get; set; }

            [NameInMap("agentStartGMT")]
            [Validation(Required=false)]
            public string AgentStartGMT { get; set; }

            [NameInMap("agentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            [NameInMap("agentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            [NameInMap("agentUuid")]
            [Validation(Required=false)]
            public string AgentUuid { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("needNoticePrincipal")]
            [Validation(Required=false)]
            public string NeedNoticePrincipal { get; set; }

            [NameInMap("principalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            [NameInMap("principalUserId")]
            [Validation(Required=false)]
            public string PrincipalUserId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
