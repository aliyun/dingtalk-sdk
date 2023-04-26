// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeQueryStudentInfoByStudentIdResponseBody : TeaModel {
        [NameInMap("deptStudentInfoList")]
        [Validation(Required=false)]
        public List<CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList> DeptStudentInfoList { get; set; }
        public class CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("studentNumber")]
            [Validation(Required=false)]
            public string StudentNumber { get; set; }

        }

        [NameInMap("dingMemberStatus")]
        [Validation(Required=false)]
        public string DingMemberStatus { get; set; }

        [NameInMap("empExtension")]
        [Validation(Required=false)]
        public Dictionary<string, object> EmpExtension { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("identifyId")]
        [Validation(Required=false)]
        public string IdentifyId { get; set; }

        [NameInMap("isActive")]
        [Validation(Required=false)]
        public bool? IsActive { get; set; }

        [NameInMap("startYear")]
        [Validation(Required=false)]
        public string StartYear { get; set; }

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

}
