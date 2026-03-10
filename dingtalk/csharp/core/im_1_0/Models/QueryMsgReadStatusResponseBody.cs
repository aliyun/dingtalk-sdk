// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryMsgReadStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMsgReadStatusResponseBodyResult Result { get; set; }
        public class QueryMsgReadStatusResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

            [NameInMap("openMessageId")]
            [Validation(Required=false)]
            public string OpenMessageId { get; set; }

            [NameInMap("readUnionIds")]
            [Validation(Required=false)]
            public List<string> ReadUnionIds { get; set; }

            [NameInMap("readUserIds")]
            [Validation(Required=false)]
            public List<string> ReadUserIds { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
