// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class AlignObjectiveRequest : TeaModel {
        /// <summary>
        /// 周期 ID
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public string PeriodId { get; set; }

        /// <summary>
        /// 对齐目标的 ID
        /// </summary>
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 用户 ID
        /// </summary>
        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public Stream OwnerId { get; set; }

    }

}
