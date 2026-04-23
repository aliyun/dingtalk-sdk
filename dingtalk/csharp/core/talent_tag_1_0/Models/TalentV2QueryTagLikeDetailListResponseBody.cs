// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktalent_tag_1_0.Models
{
    public class TalentV2QueryTagLikeDetailListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentV2QueryTagLikeDetailListResponseBodyResult Result { get; set; }
        public class TalentV2QueryTagLikeDetailListResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("likeDetails")]
            [Validation(Required=false)]
            public List<TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails> LikeDetails { get; set; }
            public class TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails : TeaModel {
                [NameInMap("likeTimestamp")]
                [Validation(Required=false)]
                public long? LikeTimestamp { get; set; }

                [NameInMap("operatorUserId")]
                [Validation(Required=false)]
                public string OperatorUserId { get; set; }

            }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

        }

    }

}
