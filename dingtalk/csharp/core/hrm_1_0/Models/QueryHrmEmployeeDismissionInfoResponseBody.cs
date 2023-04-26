// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryHrmEmployeeDismissionInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryHrmEmployeeDismissionInfoResponseBodyResult> Result { get; set; }
        public class QueryHrmEmployeeDismissionInfoResponseBodyResult : TeaModel {
            [NameInMap("deptList")]
            [Validation(Required=false)]
            public List<QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList> DeptList { get; set; }
            public class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList : TeaModel {
                [NameInMap("dept_id")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("dept_path")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

            }

            [NameInMap("handoverUserId")]
            [Validation(Required=false)]
            public string HandoverUserId { get; set; }

            [NameInMap("lastWorkDay")]
            [Validation(Required=false)]
            public long? LastWorkDay { get; set; }

            [NameInMap("mainDeptId")]
            [Validation(Required=false)]
            public long? MainDeptId { get; set; }

            [NameInMap("mainDeptName")]
            [Validation(Required=false)]
            public string MainDeptName { get; set; }

            [NameInMap("passiveReason")]
            [Validation(Required=false)]
            public List<string> PassiveReason { get; set; }

            [NameInMap("preStatus")]
            [Validation(Required=false)]
            public int? PreStatus { get; set; }

            [NameInMap("reasonMemo")]
            [Validation(Required=false)]
            public string ReasonMemo { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("voluntaryReason")]
            [Validation(Required=false)]
            public List<string> VoluntaryReason { get; set; }

        }

    }

}
