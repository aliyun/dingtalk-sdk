// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateAutoLoginUrlResponseBody : TeaModel {
        [NameInMap("loginInfo")]
        [Validation(Required=false)]
        public CreateAutoLoginUrlResponseBodyLoginInfo LoginInfo { get; set; }
        public class CreateAutoLoginUrlResponseBodyLoginInfo : TeaModel {
            [NameInMap("loginUrl")]
            [Validation(Required=false)]
            public string LoginUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
