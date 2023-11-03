// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class ConsumePointResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ConsumePointResponseBodyResult Result { get; set; }
        public class ConsumePointResponseBodyResult : TeaModel {
            [NameInMap("consumedPoints")]
            [Validation(Required=false)]
            public long? ConsumedPoints { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
