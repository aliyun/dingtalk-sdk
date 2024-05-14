// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveCreateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("punchParam")]
        [Validation(Required=false)]
        public ProcessApproveCreateRequestPunchParam PunchParam { get; set; }
        public class ProcessApproveCreateRequestPunchParam : TeaModel {
            [NameInMap("positionId")]
            [Validation(Required=false)]
            public string PositionId { get; set; }

            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            [NameInMap("positionType")]
            [Validation(Required=false)]
            public string PositionType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("punchTime")]
            [Validation(Required=false)]
            public long? PunchTime { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
