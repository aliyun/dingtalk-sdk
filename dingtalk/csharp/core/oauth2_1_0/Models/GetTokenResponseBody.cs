// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetTokenResponseBody : TeaModel {
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public int? ExpiresIn { get; set; }

    }

}
