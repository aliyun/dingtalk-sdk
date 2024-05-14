// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardQueryCardFeedsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardBizCode")]
        [Validation(Required=false)]
        public string CardBizCode { get; set; }

        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public long? CardId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("feedType")]
        [Validation(Required=false)]
        public int? FeedType { get; set; }

        [NameInMap("needFinishProcess")]
        [Validation(Required=false)]
        public bool? NeedFinishProcess { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("studentId")]
        [Validation(Required=false)]
        public string StudentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subBizId")]
        [Validation(Required=false)]
        public string SubBizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
