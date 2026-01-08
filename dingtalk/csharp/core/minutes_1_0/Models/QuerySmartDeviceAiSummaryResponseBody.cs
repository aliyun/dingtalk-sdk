// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QuerySmartDeviceAiSummaryResponseBody : TeaModel {
        [NameInMap("aiSummaryList")]
        [Validation(Required=false)]
        public List<QuerySmartDeviceAiSummaryResponseBodyAiSummaryList> AiSummaryList { get; set; }
        public class QuerySmartDeviceAiSummaryResponseBodyAiSummaryList : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("aiSceneRuleAvatarUrl")]
            [Validation(Required=false)]
            public string AiSceneRuleAvatarUrl { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("openFileId")]
            [Validation(Required=false)]
            public string OpenFileId { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
