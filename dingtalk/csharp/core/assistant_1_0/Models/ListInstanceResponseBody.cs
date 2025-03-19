// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class ListInstanceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyResult> Result { get; set; }
        public class ListInstanceResponseBodyResult : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("prototypeAssistantId")]
            [Validation(Required=false)]
            public string PrototypeAssistantId { get; set; }

            [NameInMap("tenantAssistantId")]
            [Validation(Required=false)]
            public string TenantAssistantId { get; set; }

        }

    }

}
