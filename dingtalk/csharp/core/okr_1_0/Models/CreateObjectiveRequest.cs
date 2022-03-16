// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class CreateObjectiveRequest : TeaModel {
        /// <summary>
        /// 创建Objective 的内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 当前周期 ID。
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public string PeriodId { get; set; }

        /// <summary>
        /// 上一个 Objective 的位置。
        /// </summary>
        [NameInMap("prevPosition")]
        [Validation(Required=false)]
        public string PrevPosition { get; set; }

        /// <summary>
        /// 当前用户的 userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
