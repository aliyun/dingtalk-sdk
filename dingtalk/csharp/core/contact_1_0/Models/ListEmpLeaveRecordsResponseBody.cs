// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListEmpLeaveRecordsResponseBody : TeaModel {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public int? DingOpenErrcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListEmpLeaveRecordsResponseBodyResult Result { get; set; }
        public class ListEmpLeaveRecordsResponseBodyResult : TeaModel {
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("records")]
            [Validation(Required=false)]
            public List<ListEmpLeaveRecordsResponseBodyResultRecords> Records { get; set; }
            public class ListEmpLeaveRecordsResponseBodyResultRecords : TeaModel {
                public string UserId { get; set; }
                public string Name { get; set; }
                public string StateCode { get; set; }
                public string Mobile { get; set; }
                public string LeaveTime { get; set; }
                public string LeaveReason { get; set; }
            }
        };

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
