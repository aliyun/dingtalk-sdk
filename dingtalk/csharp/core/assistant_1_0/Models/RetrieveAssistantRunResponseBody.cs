// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class RetrieveAssistantRunResponseBody : TeaModel {
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("cancelledAt")]
        [Validation(Required=false)]
        public long? CancelledAt { get; set; }

        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("expiresAt")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        [NameInMap("failedAt")]
        [Validation(Required=false)]
        public long? FailedAt { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("lastErrorMsg")]
        [Validation(Required=false)]
        public string LastErrorMsg { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public long? StartedAt { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
