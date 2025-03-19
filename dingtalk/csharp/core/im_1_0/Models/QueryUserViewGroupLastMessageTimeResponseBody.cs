// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUserViewGroupLastMessageTimeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserViewGroupLastMessageTimeResponseBodyResult Result { get; set; }
        public class QueryUserViewGroupLastMessageTimeResponseBodyResult : TeaModel {
            [NameInMap("time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
