// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardQueryCardFeedsRequest : TeaModel {
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("cardBizCode")]
        [Validation(Required=false)]
        public string CardBizCode { get; set; }

        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        [NameInMap("cardId")]
        [Validation(Required=false)]
        public long? CardId { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        [NameInMap("feedType")]
        [Validation(Required=false)]
        public int? FeedType { get; set; }

        [NameInMap("needFinishProcess")]
        [Validation(Required=false)]
        public bool? NeedFinishProcess { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("studentId")]
        [Validation(Required=false)]
        public string StudentId { get; set; }

        [NameInMap("subBizId")]
        [Validation(Required=false)]
        public string SubBizId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
