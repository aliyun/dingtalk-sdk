// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveCreateRequest : TeaModel {
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

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

        }

        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
