// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetUserInfoByOpenTokenRequest : TeaModel {
        [NameInMap("docKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        [NameInMap("openToken")]
        [Validation(Required=false)]
        public string OpenToken { get; set; }

    }

}
