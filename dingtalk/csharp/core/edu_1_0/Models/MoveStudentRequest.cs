// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class MoveStudentRequest : TeaModel {
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("originClassId")]
        [Validation(Required=false)]
        public long? OriginClassId { get; set; }

        [NameInMap("targetClassId")]
        [Validation(Required=false)]
        public long? TargetClassId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
