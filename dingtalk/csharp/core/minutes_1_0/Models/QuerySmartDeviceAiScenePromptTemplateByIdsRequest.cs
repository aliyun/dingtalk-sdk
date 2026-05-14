// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QuerySmartDeviceAiScenePromptTemplateByIdsRequest : TeaModel {
        [NameInMap("agentInstanceId")]
        [Validation(Required=false)]
        public string AgentInstanceId { get; set; }

        [NameInMap("agentPromptTemplateIds")]
        [Validation(Required=false)]
        public List<string> AgentPromptTemplateIds { get; set; }

    }

}
