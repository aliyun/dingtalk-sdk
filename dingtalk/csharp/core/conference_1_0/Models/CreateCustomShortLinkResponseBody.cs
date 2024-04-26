// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateCustomShortLinkResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCustomShortLinkResponseBodyResult Result { get; set; }
        public class CreateCustomShortLinkResponseBodyResult : TeaModel {
            [NameInMap("customShortLink")]
            [Validation(Required=false)]
            public string CustomShortLink { get; set; }

        }

    }

}
