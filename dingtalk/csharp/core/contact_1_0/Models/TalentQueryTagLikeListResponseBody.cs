// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentQueryTagLikeListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentQueryTagLikeListResponseBodyResult Result { get; set; }
        public class TalentQueryTagLikeListResponseBodyResult : TeaModel {
            [NameInMap("tagLikes")]
            [Validation(Required=false)]
            public List<TalentQueryTagLikeListResponseBodyResultTagLikes> TagLikes { get; set; }
            public class TalentQueryTagLikeListResponseBodyResultTagLikes : TeaModel {
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
