// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_interaction_1_0.Models
{
    public class ReplyResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ReplyResponseBodyResult Result { get; set; }
        public class ReplyResponseBodyResult : TeaModel {
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
