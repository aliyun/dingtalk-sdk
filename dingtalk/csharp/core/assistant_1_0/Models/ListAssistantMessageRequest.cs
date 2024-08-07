// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class ListAssistantMessageRequest : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

    }

}
