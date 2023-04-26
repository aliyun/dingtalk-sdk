// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ListApproveByUsersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListApproveByUsersResponseBodyResult> Result { get; set; }
        public class ListApproveByUsersResponseBodyResult : TeaModel {
            [NameInMap("approveId")]
            [Validation(Required=false)]
            public string ApproveId { get; set; }

            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("calculateModel")]
            [Validation(Required=false)]
            public int? CalculateModel { get; set; }

            [NameInMap("durationUnit")]
            [Validation(Required=false)]
            public string DurationUnit { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

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

}
