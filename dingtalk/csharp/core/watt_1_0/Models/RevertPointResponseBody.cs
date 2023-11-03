// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class RevertPointResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RevertPointResponseBodyResult Result { get; set; }
        public class RevertPointResponseBodyResult : TeaModel {
            [NameInMap("revertedPoints")]
            [Validation(Required=false)]
            public long? RevertedPoints { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
