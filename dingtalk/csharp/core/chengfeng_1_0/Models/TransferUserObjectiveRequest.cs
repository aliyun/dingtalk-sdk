// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class TransferUserObjectiveRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
