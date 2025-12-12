// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_2_0.Models
{
    public class CreateAssistantMessageResponseBody : TeaModel {
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
