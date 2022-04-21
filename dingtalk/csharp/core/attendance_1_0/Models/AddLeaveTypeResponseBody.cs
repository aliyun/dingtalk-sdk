// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AddLeaveTypeResponseBody : TeaModel {
        /// <summary>
        /// 返回参数
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
                /// <summary>
                /// 超过多长时间需提供请假证明
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// 是否开启请假证明
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// 请假提示文案
                /// </summary>
                [NameInMap("promptInformation")]
                [Validation(Required=false)]
                public string PromptInformation { get; set; }

                /// <summary>
                /// 请假证明单位hour，day
                /// </summary>
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
                /// <summary>
                /// 是否开启限时提交功能：仅且为true时开启
                /// </summary>
                [NameInMap("enableTimeLimit")]
                [Validation(Required=false)]
                public bool? EnableTimeLimit { get; set; }

                /// <summary>
                /// 限制类型：before-提前；after-补交
                /// </summary>
                [NameInMap("timeType")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                /// <summary>
                /// 时间单位：day-天；hour-小时
                /// </summary>
                [NameInMap("timeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
                /// </summary>
                [NameInMap("timeValue")]
                [Validation(Required=false)]
                public long? TimeValue { get; set; }

            }
        };

    }

}
