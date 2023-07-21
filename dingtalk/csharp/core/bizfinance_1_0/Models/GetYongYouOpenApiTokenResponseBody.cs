// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetYongYouOpenApiTokenResponseBody : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("expiresIn")]
        [Validation(Required=false)]
        public string ExpiresIn { get; set; }

        [NameInMap("refreshExpiresIn")]
        [Validation(Required=false)]
        public string RefreshExpiresIn { get; set; }

        [NameInMap("refreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        [NameInMap("yongyouOrgId")]
        [Validation(Required=false)]
        public string YongyouOrgId { get; set; }

        [NameInMap("yongyouUserId")]
        [Validation(Required=false)]
        public string YongyouUserId { get; set; }

    }

}
