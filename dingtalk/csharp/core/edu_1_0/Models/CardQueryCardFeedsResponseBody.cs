// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardQueryCardFeedsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CardQueryCardFeedsResponseBodyResult Result { get; set; }
        public class CardQueryCardFeedsResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("posts")]
            [Validation(Required=false)]
            public List<CardQueryCardFeedsResponseBodyResultPosts> Posts { get; set; }
            public class CardQueryCardFeedsResponseBodyResultPosts : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public CardQueryCardFeedsResponseBodyResultPostsAuthor Author { get; set; }
                public class CardQueryCardFeedsResponseBodyResultPostsAuthor : TeaModel {
                    [NameInMap("showName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("userRole")]
                    [Validation(Required=false)]
                    public string UserRole { get; set; }

                }

                [NameInMap("bizType")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public CardQueryCardFeedsResponseBodyResultPostsContent Content { get; set; }
                public class CardQueryCardFeedsResponseBodyResultPostsContent : TeaModel {
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public int? ContentType { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("createAt")]
                [Validation(Required=false)]
                public long? CreateAt { get; set; }

                [NameInMap("feedType")]
                [Validation(Required=false)]
                public int? FeedType { get; set; }

                [NameInMap("postId")]
                [Validation(Required=false)]
                public long? PostId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
