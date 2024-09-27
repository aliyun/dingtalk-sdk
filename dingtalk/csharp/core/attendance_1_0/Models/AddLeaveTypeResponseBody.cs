// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AddLeaveTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddLeaveTypeResponseBodyResult Result { get; set; }
        public class AddLeaveTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>general_leave</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("hoursInPerDay")]
            [Validation(Required=false)]
            public long? HoursInPerDay { get; set; }

            [NameInMap("leaveCertificate")]
            [Validation(Required=false)]
            public AddLeaveTypeResponseBodyResultLeaveCertificate LeaveCertificate { get; set; }
            public class AddLeaveTypeResponseBodyResultLeaveCertificate : TeaModel {
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
            /// <para>037477ae-1009-4632-b8e9-e919ae5e7973</para>
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
            public AddLeaveTypeResponseBodyResultSubmitTimeRule SubmitTimeRule { get; set; }
            public class AddLeaveTypeResponseBodyResultSubmitTimeRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("timeValue")]
                [Validation(Required=false)]
                public long? TimeValue { get; set; }

            }

            [NameInMap("visibilityRules")]
            [Validation(Required=false)]
            public List<AddLeaveTypeResponseBodyResultVisibilityRules> VisibilityRules { get; set; }
            public class AddLeaveTypeResponseBodyResultVisibilityRules : TeaModel {
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

        }

    }

}
