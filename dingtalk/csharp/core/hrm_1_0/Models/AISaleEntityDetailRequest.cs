// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleEntityDetailRequest : TeaModel {
        [NameInMap("entityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
