// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleSyncAiTaskRequest : TeaModel {
        [NameInMap("scenarioCode")]
        [Validation(Required=false)]
        public string ScenarioCode { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
