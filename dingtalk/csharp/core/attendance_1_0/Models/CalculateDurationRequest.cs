// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CalculateDurationRequest : TeaModel {
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public long? BizType { get; set; }

        [NameInMap("calculateModel")]
        [Validation(Required=false)]
        public long? CalculateModel { get; set; }

        [NameInMap("durationUnit")]
        [Validation(Required=false)]
        public string DurationUnit { get; set; }

        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public string FromTime { get; set; }

        [NameInMap("leaveCode")]
        [Validation(Required=false)]
        public string LeaveCode { get; set; }

        [NameInMap("toTime")]
        [Validation(Required=false)]
        public string ToTime { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
