// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetSsoAccessTokenRequest : TeaModel {
        [NameInMap("corpid")]
        [Validation(Required=false)]
        public string Corpid { get; set; }

        [NameInMap("ssoSecret")]
        [Validation(Required=false)]
        public string SsoSecret { get; set; }

    }

}
