// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class RegisterCallbackRequest : TeaModel {
        /// <summary>
        /// 加密密钥用于校验来源
        /// </summary>
        [NameInMap("apiSecret")]
        [Validation(Required=false)]
        public string ApiSecret { get; set; }

        /// <summary>
        /// callbackUrl 的路由 Key，一个 callbackRouteKey 可以映射一个 callbackUrl
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// 注册的回调 URL
        /// </summary>
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 是否强制覆盖更新，默认 false
        /// </summary>
        [NameInMap("forceUpdate")]
        [Validation(Required=false)]
        public bool? ForceUpdate { get; set; }

    }

}
