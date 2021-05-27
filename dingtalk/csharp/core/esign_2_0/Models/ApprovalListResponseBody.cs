// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ApprovalListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ApprovalListResponseBodyData> Data { get; set; }
        public class ApprovalListResponseBodyData : TeaModel {
            [NameInMap("approvalName")]
            [Validation(Required=false)]
            public string ApprovalName { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("refuseReason")]
            [Validation(Required=false)]
            public string RefuseReason { get; set; }

            [NameInMap("sponsorAccountName")]
            [Validation(Required=false)]
            public string SponsorAccountName { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public float? StartTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public float? EndTime { get; set; }

            [NameInMap("sealIdImg")]
            [Validation(Required=false)]
            public string SealIdImg { get; set; }

            [NameInMap("approvalNodes")]
            [Validation(Required=false)]
            public List<ApprovalListResponseBodyDataApprovalNodes> ApprovalNodes { get; set; }
            public class ApprovalListResponseBodyDataApprovalNodes : TeaModel {
                [NameInMap("approverName")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

                [NameInMap("approvalTime")]
                [Validation(Required=false)]
                public string ApprovalTime { get; set; }

            }

        }

    }

}
