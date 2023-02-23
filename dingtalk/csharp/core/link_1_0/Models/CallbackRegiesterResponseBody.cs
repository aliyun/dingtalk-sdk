// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class CallbackRegiesterResponseBody : TeaModel {
        /// <summary>
        /// 注册结果详情
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CallbackRegiesterResponseBodyResult Result { get; set; }
        public class CallbackRegiesterResponseBodyResult : TeaModel {
            /// <summary>
            /// 成功注册的api secret
            /// </summary>
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            /// <summary>
            /// 成功注册的url
            /// </summary>
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

        }

    }

}
