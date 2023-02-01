// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class RecallHonorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RecallHonorResponseBodyResult Result { get; set; }
        public class RecallHonorResponseBodyResult : TeaModel {
            [NameInMap("honorId")]
            [Validation(Required=false)]
            public string HonorId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
