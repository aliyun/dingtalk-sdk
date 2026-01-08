// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddConvNavTabResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddConvNavTabResponseBodyResult Result { get; set; }
        public class AddConvNavTabResponseBodyResult : TeaModel {
            [NameInMap("tabId")]
            [Validation(Required=false)]
            public string TabId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
