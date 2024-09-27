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
            /// <summary>
            /// <b>Example:</b>
            /// <para>lieu_leave</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("hoursInPerDay")]
            [Validation(Required=false)]
            public long? HoursInPerDay { get; set; }

            [NameInMap("leaveCertificate")]
            [Validation(Required=false)]
            public RetainLeaveTypesResponseBodyResultLeaveCertificate LeaveCertificate { get; set; }
            public class RetainLeaveTypesResponseBodyResultLeaveCertificate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>leaveCertificate</para>
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
            /// <para>2e8b764e-7989-4b5d-ac64-xxxxx</para>
            /// </summary>
            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("leaveHourCeil")]
            [Validation(Required=false)]
            public string LeaveHourCeil { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>高级测试假期</para>
            /// </summary>
            [NameInMap("leaveName")]
            [Validation(Required=false)]
            public string LeaveName { get; set; }

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
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("leaveViewUnit")]
            [Validation(Required=false)]
            public string LeaveViewUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("lieuDelayNum")]
            [Validation(Required=false)]
            public long? LieuDelayNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("lieuDelayUnit")]
            [Validation(Required=false)]
            public string LieuDelayUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("maxLeaveTime")]
            [Validation(Required=false)]
            public long? MaxLeaveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>after</para>
                /// </summary>
                [NameInMap("timeType")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hour</para>
                /// </summary>
                [NameInMap("timeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("timeValue")]
                [Validation(Required=false)]
                public long? TimeValue { get; set; }

            }

            [NameInMap("visibilityRules")]
            [Validation(Required=false)]
            public List<RetainLeaveTypesResponseBodyResultVisibilityRules> VisibilityRules { get; set; }
            public class RetainLeaveTypesResponseBodyResultVisibilityRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dept</para>
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
            /// <para>formal</para>
            /// </summary>
            [NameInMap("whenCanLeave")]
            [Validation(Required=false)]
            public string WhenCanLeave { get; set; }

        }

    }

}
