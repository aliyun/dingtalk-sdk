// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class ListSealApprovalResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSealApprovalResponseBodyData> Data { get; set; }
        public class ListSealApprovalResponseBodyData : TeaModel {
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
            public long? StartTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("sealIdImg")]
            [Validation(Required=false)]
            public string SealIdImg { get; set; }

            [NameInMap("approvalNodes")]
            [Validation(Required=false)]
            public List<ListSealApprovalResponseBodyDataApprovalNodes> ApprovalNodes { get; set; }
            public class ListSealApprovalResponseBodyDataApprovalNodes : TeaModel {
                [NameInMap("approverName")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("approvalTime")]
                [Validation(Required=false)]
                public long? ApprovalTime { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
