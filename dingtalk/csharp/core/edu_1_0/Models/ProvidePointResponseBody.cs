// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ProvidePointResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProvidePointResponseBodyResult Result { get; set; }
        public class ProvidePointResponseBodyResult : TeaModel {
            [NameInMap("availableQuota")]
            [Validation(Required=false)]
            public long? AvailableQuota { get; set; }

            [NameInMap("provideNum")]
            [Validation(Required=false)]
            public long? ProvideNum { get; set; }

            [NameInMap("provideSuccess")]
            [Validation(Required=false)]
            public bool? ProvideSuccess { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
