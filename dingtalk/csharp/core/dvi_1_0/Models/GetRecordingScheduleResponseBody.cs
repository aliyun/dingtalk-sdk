// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetRecordingScheduleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRecordingScheduleResponseBodyResult Result { get; set; }
        public class GetRecordingScheduleResponseBodyResult : TeaModel {
            [NameInMap("businessOrder")]
            [Validation(Required=false)]
            public string BusinessOrder { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
