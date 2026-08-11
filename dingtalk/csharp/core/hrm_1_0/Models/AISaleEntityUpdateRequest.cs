// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleEntityUpdateRequest : TeaModel {
        [NameInMap("entityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("fieldInstances")]
        [Validation(Required=false)]
        public List<AISaleEntityUpdateRequestFieldInstances> FieldInstances { get; set; }
        public class AISaleEntityUpdateRequestFieldInstances : TeaModel {
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
