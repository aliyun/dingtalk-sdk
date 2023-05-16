// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class RetainLeaveTypesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<RetainLeaveTypesResponseBodyResult> Result { get; set; }
        public class RetainLeaveTypesResponseBodyResult : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("hoursInPerDay")]
            [Validation(Required=false)]
            public long? HoursInPerDay { get; set; }

            [NameInMap("leaveCertificate")]
            [Validation(Required=false)]
            public RetainLeaveTypesResponseBodyResultLeaveCertificate LeaveCertificate { get; set; }
            public class RetainLeaveTypesResponseBodyResultLeaveCertificate : TeaModel {
                [NameInMap("duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("promptInformation")]
                [Validation(Required=false)]
                public string PromptInformation { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            [NameInMap("leaveHourCeil")]
            [Validation(Required=false)]
            public string LeaveHourCeil { get; set; }

            [NameInMap("leaveName")]
            [Validation(Required=false)]
            public string LeaveName { get; set; }

            [NameInMap("leaveTimeCeil")]
            [Validation(Required=false)]
            public bool? LeaveTimeCeil { get; set; }

            [NameInMap("leaveTimeCeilMinUnit")]
            [Validation(Required=false)]
            public string LeaveTimeCeilMinUnit { get; set; }

            [NameInMap("leaveViewUnit")]
            [Validation(Required=false)]
            public string LeaveViewUnit { get; set; }

            [NameInMap("lieuDelayNum")]
            [Validation(Required=false)]
            public long? LieuDelayNum { get; set; }

            [NameInMap("lieuDelayUnit")]
            [Validation(Required=false)]
            public string LieuDelayUnit { get; set; }

            [NameInMap("maxLeaveTime")]
            [Validation(Required=false)]
            public long? MaxLeaveTime { get; set; }

            [NameInMap("minLeaveHour")]
            [Validation(Required=false)]
            public double? MinLeaveHour { get; set; }

            [NameInMap("naturalDayLeave")]
            [Validation(Required=false)]
            public bool? NaturalDayLeave { get; set; }

            [NameInMap("paidLeave")]
            [Validation(Required=false)]
            public bool? PaidLeave { get; set; }

            [NameInMap("submitTimeRule")]
            [Validation(Required=false)]
            public RetainLeaveTypesResponseBodyResultSubmitTimeRule SubmitTimeRule { get; set; }
            public class RetainLeaveTypesResponseBodyResultSubmitTimeRule : TeaModel {
                [NameInMap("enableTimeLimit")]
                [Validation(Required=false)]
                public bool? EnableTimeLimit { get; set; }

                [NameInMap("timeType")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                [NameInMap("timeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                [NameInMap("timeValue")]
                [Validation(Required=false)]
                public long? TimeValue { get; set; }

            }

            [NameInMap("visibilityRules")]
            [Validation(Required=false)]
            public List<RetainLeaveTypesResponseBodyResultVisibilityRules> VisibilityRules { get; set; }
            public class RetainLeaveTypesResponseBodyResultVisibilityRules : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("visible")]
                [Validation(Required=false)]
                public List<string> Visible { get; set; }

            }

            [NameInMap("whenCanLeave")]
            [Validation(Required=false)]
            public string WhenCanLeave { get; set; }

        }

    }

}
