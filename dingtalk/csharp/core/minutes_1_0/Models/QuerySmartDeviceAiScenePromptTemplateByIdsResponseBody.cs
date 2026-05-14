// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody : TeaModel {
        [NameInMap("agentPromptTemplates")]
        [Validation(Required=false)]
        public List<QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates> AgentPromptTemplates { get; set; }
        public class QuerySmartDeviceAiScenePromptTemplateByIdsResponseBodyAgentPromptTemplates : TeaModel {
            [NameInMap("agentPromptTemplateId")]
            [Validation(Required=false)]
            public string AgentPromptTemplateId { get; set; }

            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("belongingId")]
            [Validation(Required=false)]
            public string BelongingId { get; set; }

            [NameInMap("belongingType")]
            [Validation(Required=false)]
            public string BelongingType { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            [NameInMap("prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
