// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class RegisterCallbackWithDelegateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RegisterCallbackWithDelegateResponseBodyResult Result { get; set; }
        public class RegisterCallbackWithDelegateResponseBodyResult : TeaModel {
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
