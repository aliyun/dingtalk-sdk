// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AddLeaveTypeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general_leave</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;validity_type&quot;:&quot;absolute_time&quot;,&quot;validity_value&quot;:&quot;12-31&quot;}</para>
        /// </summary>
        [NameInMap("extras")]
        [Validation(Required=false)]
        public string Extras { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("freedomLeave")]
        [Validation(Required=false)]
        public bool? FreedomLeave { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hoursInPerDay")]
        [Validation(Required=false)]
        public long? HoursInPerDay { get; set; }

        [NameInMap("leaveCertificate")]
        [Validation(Required=false)]
        public AddLeaveTypeRequestLeaveCertificate LeaveCertificate { get; set; }
        public class AddLeaveTypeRequestLeaveCertificate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>请假文案</para>
            /// </summary>
            [NameInMap("promptInformation")]
            [Validation(Required=false)]
            public string PromptInformation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("leaveHourCeil")]
        [Validation(Required=false)]
        public string LeaveHourCeil { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>年假</para>
        /// </summary>
        [NameInMap("leaveName")]
        [Validation(Required=false)]
        public string LeaveName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("leaveTimeCeil")]
        [Validation(Required=false)]
        public bool? LeaveTimeCeil { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hour</para>
        /// </summary>
        [NameInMap("leaveTimeCeilMinUnit")]
        [Validation(Required=false)]
        public string LeaveTimeCeilMinUnit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("leaveViewUnit")]
        [Validation(Required=false)]
        public string LeaveViewUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("maxLeaveTime")]
        [Validation(Required=false)]
        public long? MaxLeaveTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("minLeaveHour")]
        [Validation(Required=false)]
        public double? MinLeaveHour { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("naturalDayLeave")]
        [Validation(Required=false)]
        public bool? NaturalDayLeave { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("paidLeave")]
        [Validation(Required=false)]
        public bool? PaidLeave { get; set; }

        [NameInMap("submitTimeRule")]
        [Validation(Required=false)]
        public AddLeaveTypeRequestSubmitTimeRule SubmitTimeRule { get; set; }
        public class AddLeaveTypeRequestSubmitTimeRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableTimeLimit")]
            [Validation(Required=false)]
            public bool? EnableTimeLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>before</para>
            /// </summary>
            [NameInMap("timeType")]
            [Validation(Required=false)]
            public string TimeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("timeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("timeValue")]
            [Validation(Required=false)]
            public long? TimeValue { get; set; }

        }

        [NameInMap("visibilityRules")]
        [Validation(Required=false)]
        public List<AddLeaveTypeRequestVisibilityRules> VisibilityRules { get; set; }
        public class AddLeaveTypeRequestVisibilityRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>staff</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("visible")]
            [Validation(Required=false)]
            public List<string> Visible { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>entry</para>
        /// </summary>
        [NameInMap("whenCanLeave")]
        [Validation(Required=false)]
        public string WhenCanLeave { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
