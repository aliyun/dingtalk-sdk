// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CirclePostDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CirclePostDetailResponseBodyResult Result { get; set; }
        public class CirclePostDetailResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("dislikeCount")]
            [Validation(Required=false)]
            public long? DislikeCount { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("likeCount")]
            [Validation(Required=false)]
            public long? LikeCount { get; set; }

            [NameInMap("mediaUrlList")]
            [Validation(Required=false)]
            public List<string> MediaUrlList { get; set; }

            [NameInMap("postId")]
            [Validation(Required=false)]
            public long? PostId { get; set; }

            [NameInMap("postType")]
            [Validation(Required=false)]
            public string PostType { get; set; }

            [NameInMap("products")]
            [Validation(Required=false)]
            public List<CirclePostDetailResponseBodyResultProducts> Products { get; set; }
            public class CirclePostDetailResponseBodyResultProducts : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("productCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tagList")]
            [Validation(Required=false)]
            public List<CirclePostDetailResponseBodyResultTagList> TagList { get; set; }
            public class CirclePostDetailResponseBodyResultTagList : TeaModel {
                [NameInMap("tagColor")]
                [Validation(Required=false)]
                public string TagColor { get; set; }

                [NameInMap("tagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("viewCount")]
            [Validation(Required=false)]
            public long? ViewCount { get; set; }

        }

    }

}
