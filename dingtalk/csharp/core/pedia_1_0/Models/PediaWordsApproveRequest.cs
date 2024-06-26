// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsApproveRequest : TeaModel {
        [NameInMap("approveReason")]
        [Validation(Required=false)]
        public string ApproveReason { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("approveStatus")]
        [Validation(Required=false)]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("imHighLight")]
        [Validation(Required=false)]
        public bool? ImHighLight { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("simHighLight")]
        [Validation(Required=false)]
        public bool? SimHighLight { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

    }

}
