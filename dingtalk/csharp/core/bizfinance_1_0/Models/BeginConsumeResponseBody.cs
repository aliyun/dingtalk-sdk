// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BeginConsumeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BeginConsumeResponseBodyResult Result { get; set; }
        public class BeginConsumeResponseBodyResult : TeaModel {
            [NameInMap("isSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

        }

    }

}
