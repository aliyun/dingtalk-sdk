// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetUserFollowStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetUserFollowStatusResponseBodyResult Result { get; set; }
        public class GetUserFollowStatusResponseBodyResult : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
