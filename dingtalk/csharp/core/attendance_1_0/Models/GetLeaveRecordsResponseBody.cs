// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetLeaveRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetLeaveRecordsResponseBodyResult Result { get; set; }
        public class GetLeaveRecordsResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("leaveRecords")]
            [Validation(Required=false)]
            public List<GetLeaveRecordsResponseBodyResultLeaveRecords> LeaveRecords { get; set; }
            public class GetLeaveRecordsResponseBodyResultLeaveRecords : TeaModel {
                [NameInMap("calType")]
                [Validation(Required=false)]
                public string CalType { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("leaveCode")]
                [Validation(Required=false)]
                public string LeaveCode { get; set; }

                [NameInMap("leaveReason")]
                [Validation(Required=false)]
                public string LeaveReason { get; set; }

                [NameInMap("leaveRecordType")]
                [Validation(Required=false)]
                public string LeaveRecordType { get; set; }

                [NameInMap("leaveStatus")]
                [Validation(Required=false)]
                public string LeaveStatus { get; set; }

                [NameInMap("leaveViewUnit")]
                [Validation(Required=false)]
                public string LeaveViewUnit { get; set; }

                [NameInMap("opUserId")]
                [Validation(Required=false)]
                public string OpUserId { get; set; }

                [NameInMap("quotaId")]
                [Validation(Required=false)]
                public string QuotaId { get; set; }

                [NameInMap("recordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                [NameInMap("recordNumPerDay")]
                [Validation(Required=false)]
                public long? RecordNumPerDay { get; set; }

                [NameInMap("recordNumPerHour")]
                [Validation(Required=false)]
                public long? RecordNumPerHour { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
