// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveCreateRequest : TeaModel {
        /// <summary>
        /// 三方审批单id，全局唯一
        /// </summary>
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        /// <summary>
        /// 审批人员工userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 审批单关联的打卡信息
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
            [NameInMap("punchTime")]
            [Validation(Required=false)]
            public long? PunchTime { get; set; }
        };

        /// <summary>
        /// 审批单子类型名称：调店:shiftGroup
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// 审批单类型名称
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// 员工的userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
