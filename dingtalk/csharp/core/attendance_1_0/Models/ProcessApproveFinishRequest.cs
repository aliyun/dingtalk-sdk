// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveFinishRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1234abcd</para>
        /// </summary>
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></para>
        /// </summary>
        [NameInMap("jumpUrl")]
        [Validation(Required=false)]
        public string JumpUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("overTimeToMore")]
        [Validation(Required=false)]
        public long? OverTimeToMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.07</para>
        /// </summary>
        [NameInMap("overtimeDuration")]
        [Validation(Required=false)]
        public string OvertimeDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>年假</para>
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请假</para>
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        [NameInMap("topCalculateApproveDurationParam")]
        [Validation(Required=false)]
        public ProcessApproveFinishRequestTopCalculateApproveDurationParam TopCalculateApproveDurationParam { get; set; }
        public class ProcessApproveFinishRequestTopCalculateApproveDurationParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public long? BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("calculateModel")]
            [Validation(Required=false)]
            public long? CalculateModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("durationUnit")]
            [Validation(Required=false)]
            public string DurationUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-08-15</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public string FromTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3afdsf-143dsadw3-ad23</para>
            /// </summary>
            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-08-15</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public string ToTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
