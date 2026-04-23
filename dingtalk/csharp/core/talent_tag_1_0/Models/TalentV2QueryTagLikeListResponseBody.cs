// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktalent_tag_1_0.Models
{
    public class TalentV2QueryTagLikeListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentV2QueryTagLikeListResponseBodyResult Result { get; set; }
        public class TalentV2QueryTagLikeListResponseBodyResult : TeaModel {
            [NameInMap("tagLikes")]
            [Validation(Required=false)]
            public List<TalentV2QueryTagLikeListResponseBodyResultTagLikes> TagLikes { get; set; }
            public class TalentV2QueryTagLikeListResponseBodyResultTagLikes : TeaModel {
                [NameInMap("hasLiked")]
                [Validation(Required=false)]
                public bool? HasLiked { get; set; }

                [NameInMap("likeCount")]
                [Validation(Required=false)]
                public int? LikeCount { get; set; }

                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

    }

}
