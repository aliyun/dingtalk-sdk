// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SyncSignEventResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SyncSignEventResponseBodyResult Result { get; set; }
        public class SyncSignEventResponseBodyResult : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
