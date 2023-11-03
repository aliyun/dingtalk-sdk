// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class GetPointInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetPointInfoResponseBodyResult Result { get; set; }
        public class GetPointInfoResponseBodyResult : TeaModel {
            [NameInMap("userPoints")]
            [Validation(Required=false)]
            public long? UserPoints { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
