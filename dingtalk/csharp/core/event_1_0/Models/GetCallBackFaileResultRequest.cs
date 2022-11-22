// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0.Models
{
    public class GetCallBackFaileResultRequest : TeaModel {
        /// <summary>
        /// 大于等于时间戳
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 小于等于时间戳
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

    }

}
