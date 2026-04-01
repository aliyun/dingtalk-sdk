// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentQueryTagLikeDetailListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentQueryTagLikeDetailListResponseBodyResult Result { get; set; }
        public class TalentQueryTagLikeDetailListResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("likeDetails")]
            [Validation(Required=false)]
            public List<TalentQueryTagLikeDetailListResponseBodyResultLikeDetails> LikeDetails { get; set; }
            public class TalentQueryTagLikeDetailListResponseBodyResultLikeDetails : TeaModel {
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
