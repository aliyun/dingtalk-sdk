// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetLeaveTypeResponseBody : TeaModel {
        /// <summary>
        /// 返回参数
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetLeaveTypeResponseBodyResult> Result { get; set; }
        public class GetLeaveTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// 每天折算的工作时长(百分之一 例如1天=10小时=1000)
            /// </summary>
            [NameInMap("hoursInPerDay")]
            [Validation(Required=false)]
            public long? HoursInPerDay { get; set; }

            /// <summary>
            /// 请假证明
            /// </summary>
            [NameInMap("leaveCertificate")]
            [Validation(Required=false)]
            public GetLeaveTypeResponseBodyResultLeaveCertificate LeaveCertificate { get; set; }
            public class GetLeaveTypeResponseBodyResultLeaveCertificate : TeaModel {
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
            };

            /// <summary>
            /// 假期类型唯一标识
            /// </summary>
            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            /// <summary>
            /// 假期名称
            /// </summary>
            [NameInMap("leaveName")]
            [Validation(Required=false)]
            public string LeaveName { get; set; }

            /// <summary>
            /// 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
            /// </summary>
            [NameInMap("leaveViewUnit")]
            [Validation(Required=false)]
            public string LeaveViewUnit { get; set; }

            /// <summary>
            /// 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
            /// </summary>
            [NameInMap("naturalDayLeave")]
            [Validation(Required=false)]
            public bool? NaturalDayLeave { get; set; }

            /// <summary>
            /// 开放接口自定义的:external oa后台新建的：inner
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 限时提交规则
            /// </summary>
            [NameInMap("submitTimeRule")]
            [Validation(Required=false)]
            public GetLeaveTypeResponseBodyResultSubmitTimeRule SubmitTimeRule { get; set; }
            public class GetLeaveTypeResponseBodyResultSubmitTimeRule : TeaModel {
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
            };

            /// <summary>
            /// 有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种
            /// </summary>
            [NameInMap("validityType")]
            [Validation(Required=false)]
            public string ValidityType { get; set; }

            /// <summary>
            /// 延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数)
            /// </summary>
            [NameInMap("validityValue")]
            [Validation(Required=false)]
            public string ValidityValue { get; set; }

        }

    }

}
