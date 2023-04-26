// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDocCreatedDeptSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDocCreatedDeptSummaryResponseBodyData> Data { get; set; }
        public class GetDocCreatedDeptSummaryResponseBodyData : TeaModel {
            [NameInMap("createDocUserCnt1d")]
            [Validation(Required=false)]
            public string CreateDocUserCnt1d { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("docCreatedCnt")]
            [Validation(Required=false)]
            public string DocCreatedCnt { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
