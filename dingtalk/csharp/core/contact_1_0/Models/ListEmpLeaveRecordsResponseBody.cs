// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListEmpLeaveRecordsResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ListEmpLeaveRecordsResponseBodyRecords> Records { get; set; }
        public class ListEmpLeaveRecordsResponseBodyRecords : TeaModel {
            [NameInMap("leaveReason")]
            [Validation(Required=false)]
            public string LeaveReason { get; set; }

            [NameInMap("leaveTime")]
            [Validation(Required=false)]
            public string LeaveTime { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
