// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListUncheckedStudentResponseBody : TeaModel {
        [NameInMap("studentInfoSimpleList")]
        [Validation(Required=false)]
        public List<CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList> StudentInfoSimpleList { get; set; }
        public class CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList : TeaModel {
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            [NameInMap("studentId")]
            [Validation(Required=false)]
            public long? StudentId { get; set; }

            [NameInMap("studentName")]
            [Validation(Required=false)]
            public string StudentName { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
