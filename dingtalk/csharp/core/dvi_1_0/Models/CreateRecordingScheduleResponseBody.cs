// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class CreateRecordingScheduleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CreateRecordingScheduleResponseBodyResult> Result { get; set; }
        public class CreateRecordingScheduleResponseBodyResult : TeaModel {
            [NameInMap("businessOrder")]
            [Validation(Required=false)]
            public string BusinessOrder { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
