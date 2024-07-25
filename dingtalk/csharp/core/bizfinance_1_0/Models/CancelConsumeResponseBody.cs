// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class CancelConsumeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CancelConsumeResponseBodyResult Result { get; set; }
        public class CancelConsumeResponseBodyResult : TeaModel {
            [NameInMap("isSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

        }

    }

}
