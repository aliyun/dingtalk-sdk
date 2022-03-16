// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryObjectiveRequest : TeaModel {
        /// <summary>
        /// 需要查看的 Objective ID。
        /// </summary>
        [NameInMap("objectiveIds")]
        [Validation(Required=false)]
        public List<string> ObjectiveIds { get; set; }

        /// <summary>
        /// 周期 ID。
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public string PeriodId { get; set; }

        /// <summary>
        /// 是否返回关联信息。
        /// </summary>
        [NameInMap("withAlign")]
        [Validation(Required=false)]
        public bool? WithAlign { get; set; }

        /// <summary>
        /// 是否返回 KR 信息。
        /// </summary>
        [NameInMap("withKr")]
        [Validation(Required=false)]
        public bool? WithKr { get; set; }

        /// <summary>
        /// 是否返回进度信息
        /// </summary>
        [NameInMap("withProgress")]
        [Validation(Required=false)]
        public bool? WithProgress { get; set; }

        /// <summary>
        /// 当前用户的 staff ID。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
