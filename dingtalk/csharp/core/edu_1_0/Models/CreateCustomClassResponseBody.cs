// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateCustomClassResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCustomClassResponseBodyResult Result { get; set; }
        public class CreateCustomClassResponseBodyResult : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
