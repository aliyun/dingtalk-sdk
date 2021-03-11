// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// accessToken
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [NameInMap("expireIn")]
        [Validation(Required=false)]
        public long? ExpireIn { get; set; }

    }

}
