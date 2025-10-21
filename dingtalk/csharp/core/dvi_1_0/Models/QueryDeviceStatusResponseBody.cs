// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryDeviceStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryDeviceStatusResponseBodyResult> Result { get; set; }
        public class QueryDeviceStatusResponseBodyResult : TeaModel {
            [NameInMap("battery")]
            [Validation(Required=false)]
            public QueryDeviceStatusResponseBodyResultBattery Battery { get; set; }
            public class QueryDeviceStatusResponseBodyResultBattery : TeaModel {
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

            }

            [NameInMap("firmware")]
            [Validation(Required=false)]
            public QueryDeviceStatusResponseBodyResultFirmware Firmware { get; set; }
            public class QueryDeviceStatusResponseBodyResultFirmware : TeaModel {
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("recordingStartTime")]
            [Validation(Required=false)]
            public QueryDeviceStatusResponseBodyResultRecordingStartTime RecordingStartTime { get; set; }
            public class QueryDeviceStatusResponseBodyResultRecordingStartTime : TeaModel {
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public QueryDeviceStatusResponseBodyResultStatus Status { get; set; }
            public class QueryDeviceStatusResponseBodyResultStatus : TeaModel {
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
