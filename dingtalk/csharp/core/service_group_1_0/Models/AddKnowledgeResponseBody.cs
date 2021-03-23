// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddKnowledgeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddKnowledgeResponseBodyResult Result { get; set; }
        public class AddKnowledgeResponseBodyResult : TeaModel {
            [NameInMap("openKnowledgeId")]
            [Validation(Required=false)]
            public string OpenKnowledgeId { get; set; }
        };

    }

}
