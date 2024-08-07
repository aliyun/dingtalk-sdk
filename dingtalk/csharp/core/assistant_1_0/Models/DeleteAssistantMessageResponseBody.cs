// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class DeleteAssistantMessageResponseBody : TeaModel {
        [NameInMap("deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

    }

}
