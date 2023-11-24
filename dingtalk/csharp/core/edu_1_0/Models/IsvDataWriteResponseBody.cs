// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class IsvDataWriteResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public IsvDataWriteResponseBodyResult Result { get; set; }
        public class IsvDataWriteResponseBodyResult : TeaModel {
            [NameInMap("needRetry")]
            [Validation(Required=false)]
            public bool? NeedRetry { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
