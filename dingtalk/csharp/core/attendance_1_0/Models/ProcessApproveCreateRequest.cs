// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveCreateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25c4c49f-cf3a-4ba1-b321-7defd93b7f89</para>
        /// </summary>
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user02</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("punchParam")]
        [Validation(Required=false)]
        public ProcessApproveCreateRequestPunchParam PunchParam { get; set; }
        public class ProcessApproveCreateRequestPunchParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>longitude_latitude</para>
            /// </summary>
            [NameInMap("positionId")]
            [Validation(Required=false)]
            public string PositionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>未来park</para>
            /// </summary>
            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gps</para>
            /// </summary>
            [NameInMap("positionType")]
            [Validation(Required=false)]
            public string PositionType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650511474978</para>
            /// </summary>
            [NameInMap("punchTime")]
            [Validation(Required=false)]
            public long? PunchTime { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shiftGroup</para>
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请假</para>
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
