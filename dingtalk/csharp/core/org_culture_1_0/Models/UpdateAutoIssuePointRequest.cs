// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class UpdateAutoIssuePointRequest : TeaModel {
        /// <summary>
        /// 企业积分自动发放数量1-10000
        /// </summary>
        [NameInMap("pointAutoNum")]
        [Validation(Required=false)]
        public long? PointAutoNum { get; set; }

        /// <summary>
        /// 企业积分自动发放状态
        /// </summary>
        [NameInMap("pointAutoState")]
        [Validation(Required=false)]
        public bool? PointAutoState { get; set; }

        /// <summary>
        /// 企业积分自动发放时间 必须为每月的1号或15号，传入1时为1号，传入15时为15号。
        /// </summary>
        [NameInMap("pointAutoTime")]
        [Validation(Required=false)]
        public long? PointAutoTime { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
