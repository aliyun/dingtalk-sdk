// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CirclePostRecordResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CirclePostRecordResponseBodyResult Result { get; set; }
        public class CirclePostRecordResponseBodyResult : TeaModel {
            [NameInMap("direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("lastPostId")]
            [Validation(Required=false)]
            public long? LastPostId { get; set; }

            [NameInMap("postsList")]
            [Validation(Required=false)]
            public List<CirclePostRecordResponseBodyResultPostsList> PostsList { get; set; }
            public class CirclePostRecordResponseBodyResultPostsList : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("postId")]
                [Validation(Required=false)]
                public long? PostId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
