// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetUserTokenRequest : TeaModel {
        /// <summary>
        /// 应用id
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用密码
        /// </summary>
        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// OAuth 2.0 临时授权码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 分为authorization_code和refresh_token。使用授权码换token，传authorization_code；使用刷新token换用户token，传refresh_token
        /// </summary>
        [NameInMap("grantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// OAuth 2.0 刷新令牌
        /// </summary>
        [NameInMap("refreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

    }

}
