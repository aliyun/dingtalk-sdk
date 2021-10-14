// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateUserOwnnessRequest : TeaModel {
        /// <summary>
        /// 删除标记
        /// </summary>
        [NameInMap("deletedFlag")]
        [Validation(Required=false)]
        public int? DeletedFlag { get; set; }

        /// <summary>
        /// 结束时间戳（毫秒）
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 业务标志id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 状态类型
        /// </summary>
        [NameInMap("ownenssType")]
        [Validation(Required=false)]
        public int? OwnenssType { get; set; }

        /// <summary>
        /// 开始时间戳（毫秒）
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
