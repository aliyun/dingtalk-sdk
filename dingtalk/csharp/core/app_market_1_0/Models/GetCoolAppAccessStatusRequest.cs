// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class GetCoolAppAccessStatusRequest : TeaModel {
        /// <summary>
        /// 免登授权码
        /// </summary>
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// 酷应用的code
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// 加密的场域业务code
        /// </summary>
        [NameInMap("encFieldBizCode")]
        [Validation(Required=false)]
        public string EncFieldBizCode { get; set; }

    }

}
