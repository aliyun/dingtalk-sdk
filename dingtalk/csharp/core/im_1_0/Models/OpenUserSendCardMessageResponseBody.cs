// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class OpenUserSendCardMessageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public OpenUserSendCardMessageResponseBodyResult Result { get; set; }
        public class OpenUserSendCardMessageResponseBodyResult : TeaModel {
            [NameInMap("openTaskId")]
            [Validation(Required=false)]
            public string OpenTaskId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
