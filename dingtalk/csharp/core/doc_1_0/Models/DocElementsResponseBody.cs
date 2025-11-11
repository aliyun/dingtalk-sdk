// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocElementsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DocElementsResponseBodyResult Result { get; set; }
        public class DocElementsResponseBodyResult : TeaModel {
            [NameInMap("elements")]
            [Validation(Required=false)]
            public List<string> Elements { get; set; }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public string NextCursor { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
