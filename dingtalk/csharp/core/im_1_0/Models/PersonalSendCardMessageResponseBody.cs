// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class PersonalSendCardMessageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PersonalSendCardMessageResponseBodyResult Result { get; set; }
        public class PersonalSendCardMessageResponseBodyResult : TeaModel {
            [NameInMap("openTaskId")]
            [Validation(Required=false)]
            public string OpenTaskId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
