// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDingReportDeptSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDingReportDeptSummaryResponseBodyData> Data { get; set; }
        public class GetDingReportDeptSummaryResponseBodyData : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("dingReportSendCnt")]
            [Validation(Required=false)]
            public string DingReportSendCnt { get; set; }

            [NameInMap("dingReportSendUsrCnt")]
            [Validation(Required=false)]
            public string DingReportSendUsrCnt { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
