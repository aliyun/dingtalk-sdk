// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CheckClosingAccountRequest : TeaModel {
        /// <summary>
        /// 员工列表
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// 时间段
        /// </summary>
        [NameInMap("userTimeRange")]
        [Validation(Required=false)]
        public List<CheckClosingAccountRequestUserTimeRange> UserTimeRange { get; set; }
        public class CheckClosingAccountRequestUserTimeRange : TeaModel {
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

        }

        /// <summary>
        /// 情景
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

    }

}
