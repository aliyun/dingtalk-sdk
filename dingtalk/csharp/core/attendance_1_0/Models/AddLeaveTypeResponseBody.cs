// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AddLeaveTypeResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddLeaveTypeResponseBodyResult Result { get; set; }
        public class AddLeaveTypeResponseBodyResult : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("hoursInPerDay")]
            [Validation(Required=false)]
            public long? HoursInPerDay { get; set; }

            [NameInMap("leaveCertificate")]
            [Validation(Required=false)]
            public AddLeaveTypeResponseBodyResultLeaveCertificate LeaveCertificate { get; set; }
            public class AddLeaveTypeResponseBodyResultLeaveCertificate : TeaModel {
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

            [NameInMap("leaveName")]
            [Validation(Required=false)]
            public string LeaveName { get; set; }

            [NameInMap("leaveViewUnit")]
            [Validation(Required=false)]
            public string LeaveViewUnit { get; set; }

            [NameInMap("naturalDayLeave")]
            [Validation(Required=false)]
            public bool? NaturalDayLeave { get; set; }

            [NameInMap("submitTimeRule")]
            [Validation(Required=false)]
            public AddLeaveTypeResponseBodyResultSubmitTimeRule SubmitTimeRule { get; set; }
            public class AddLeaveTypeResponseBodyResultSubmitTimeRule : TeaModel {
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
            public List<AddLeaveTypeResponseBodyResultVisibilityRules> VisibilityRules { get; set; }
            public class AddLeaveTypeResponseBodyResultVisibilityRules : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("visible")]
                [Validation(Required=false)]
                public List<string> Visible { get; set; }

            }

        }

    }

}
