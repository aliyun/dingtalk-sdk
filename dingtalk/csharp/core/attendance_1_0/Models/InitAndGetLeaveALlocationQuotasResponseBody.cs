// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class InitAndGetLeaveALlocationQuotasResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<InitAndGetLeaveALlocationQuotasResponseBodyResult> Result { get; set; }
        public class InitAndGetLeaveALlocationQuotasResponseBodyResult : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            [NameInMap("quotaCycle")]
            [Validation(Required=false)]
            public string QuotaCycle { get; set; }

            [NameInMap("quotaId")]
            [Validation(Required=false)]
            public string QuotaId { get; set; }

            [NameInMap("quotaNumPerDay")]
            [Validation(Required=false)]
            public long? QuotaNumPerDay { get; set; }

            [NameInMap("quotaNumPerHour")]
            [Validation(Required=false)]
            public long? QuotaNumPerHour { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("usedNumPerDay")]
            [Validation(Required=false)]
            public long? UsedNumPerDay { get; set; }

            [NameInMap("usedNumPerHour")]
            [Validation(Required=false)]
            public long? UsedNumPerHour { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
