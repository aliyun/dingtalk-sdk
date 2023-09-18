// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocUpdateContentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DocUpdateContentResponseBodyResult Result { get; set; }
        public class DocUpdateContentResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
