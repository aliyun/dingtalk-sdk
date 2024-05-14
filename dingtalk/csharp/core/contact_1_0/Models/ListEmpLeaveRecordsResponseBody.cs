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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ListEmpLeaveRecordsResponseBodyRecords> Records { get; set; }
        public class ListEmpLeaveRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("leaveReason")]
            [Validation(Required=false)]
            public string LeaveReason { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("leaveTime")]
            [Validation(Required=false)]
            public string LeaveTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
