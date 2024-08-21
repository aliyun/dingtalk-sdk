// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class UpdateAssistantBasicInfoResponseBody : TeaModel {
        [NameInMap("actionNames")]
        [Validation(Required=false)]
        public List<string> ActionNames { get; set; }

        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("fallbackContent")]
        [Validation(Required=false)]
        public string FallbackContent { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        [NameInMap("knowledgeFileNames")]
        [Validation(Required=false)]
        public List<string> KnowledgeFileNames { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("recommendPrompts")]
        [Validation(Required=false)]
        public List<string> RecommendPrompts { get; set; }

        [NameInMap("unifiedAppId")]
        [Validation(Required=false)]
        public string UnifiedAppId { get; set; }

        [NameInMap("welcomeContent")]
        [Validation(Required=false)]
        public string WelcomeContent { get; set; }

    }

}
