// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGeneralFormCreatedDeptSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGeneralFormCreatedDeptSummaryResponseBodyData> Data { get; set; }
        public class GetGeneralFormCreatedDeptSummaryResponseBodyData : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("generalFormCreateCnt1d")]
            [Validation(Required=false)]
            public string GeneralFormCreateCnt1d { get; set; }

            [NameInMap("useGeneralFormUserCnt1d")]
            [Validation(Required=false)]
            public string UseGeneralFormUserCnt1d { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
