// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class UpdateLeaveTypeRequest : TeaModel {
        /// <summary>
        /// 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// 调休假有效期规则(validity_type:有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种 validity_value:延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数))
        /// </summary>
        [NameInMap("extras")]
        [Validation(Required=false)]
        public string Extras { get; set; }

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
        public UpdateLeaveTypeRequestLeaveCertificate LeaveCertificate { get; set; }
        public class UpdateLeaveTypeRequestLeaveCertificate : TeaModel {
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
        /// 限时提交规则
        /// </summary>
        [NameInMap("submitTimeRule")]
        [Validation(Required=false)]
        public UpdateLeaveTypeRequestSubmitTimeRule SubmitTimeRule { get; set; }
        public class UpdateLeaveTypeRequestSubmitTimeRule : TeaModel {
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

        /// <summary>
        /// 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        /// </summary>
        [NameInMap("visibilityRules")]
        [Validation(Required=false)]
        public List<UpdateLeaveTypeRequestVisibilityRules> VisibilityRules { get; set; }
        public class UpdateLeaveTypeRequestVisibilityRules : TeaModel {
            /// <summary>
            /// 规则类型：dept-部门；staff-员工；label-角色
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public List<string> Visible { get; set; }

        }

        /// <summary>
        /// 操作者ID
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
