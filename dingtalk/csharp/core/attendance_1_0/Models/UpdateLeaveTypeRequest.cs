// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class UpdateLeaveTypeRequest : TeaModel {
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

        [NameInMap("freedomLeave")]
        [Validation(Required=false)]
        public bool? FreedomLeave { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hoursInPerDay")]
        [Validation(Required=false)]
        public long? HoursInPerDay { get; set; }

        [NameInMap("leaveCertificate")]
        [Validation(Required=false)]
        public UpdateLeaveTypeRequestLeaveCertificate LeaveCertificate { get; set; }
        public class UpdateLeaveTypeRequestLeaveCertificate : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>047477ae-1009-4632-b8e9-e919ae5e7973</para>
        /// </summary>
        [NameInMap("leaveCode")]
        [Validation(Required=false)]
        public string LeaveCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>年假</para>
        /// </summary>
        [NameInMap("leaveName")]
        [Validation(Required=false)]
        public string LeaveName { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("naturalDayLeave")]
        [Validation(Required=false)]
        public bool? NaturalDayLeave { get; set; }

        [NameInMap("submitTimeRule")]
        [Validation(Required=false)]
        public UpdateLeaveTypeRequestSubmitTimeRule SubmitTimeRule { get; set; }
        public class UpdateLeaveTypeRequestSubmitTimeRule : TeaModel {
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
        public List<UpdateLeaveTypeRequestVisibilityRules> VisibilityRules { get; set; }
        public class UpdateLeaveTypeRequestVisibilityRules : TeaModel {
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
