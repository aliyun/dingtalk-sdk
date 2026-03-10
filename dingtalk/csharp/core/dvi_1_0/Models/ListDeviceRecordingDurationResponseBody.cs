// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class ListDeviceRecordingDurationResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDeviceRecordingDurationResponseBodyResult> Result { get; set; }
        public class ListDeviceRecordingDurationResponseBodyResult : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("endTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("startTimestamp")]
            [Validation(Required=false)]
            public long? StartTimestamp { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
