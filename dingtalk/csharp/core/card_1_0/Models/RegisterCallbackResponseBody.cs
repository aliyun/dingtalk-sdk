// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class RegisterCallbackResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RegisterCallbackResponseBodyResult Result { get; set; }
        public class RegisterCallbackResponseBodyResult : TeaModel {
            /// <summary>
            /// api 签名密钥
            /// </summary>
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            /// <summary>
            /// ISV 接受动态卡片点击的回调地址
            /// </summary>
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
