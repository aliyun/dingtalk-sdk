// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListCollegeSubDeptResponseBody : TeaModel {
        [NameInMap("collegeDeptInfoSimpleList")]
        [Validation(Required=false)]
        public List<CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList> CollegeDeptInfoSimpleList { get; set; }
        public class CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

        }

    }

}
