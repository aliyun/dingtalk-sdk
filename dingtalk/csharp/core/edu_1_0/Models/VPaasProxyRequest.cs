// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class VPaasProxyRequest : TeaModel {
        /// <summary>
        /// 代理操作码
        /// </summary>
        [NameInMap("actionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        /// <summary>
        /// 调用参数
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// Base64加密的公钥
        /// </summary>
        [NameInMap("publicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

    }

}
