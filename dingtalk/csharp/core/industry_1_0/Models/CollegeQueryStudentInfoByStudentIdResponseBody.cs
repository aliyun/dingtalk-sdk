// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeQueryStudentInfoByStudentIdResponseBody : TeaModel {
        /// <summary>
        /// 部门拓展信息列表
        /// </summary>
        [NameInMap("deptStudentInfoList")]
        [Validation(Required=false)]
        public List<CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList> DeptStudentInfoList { get; set; }
        public class CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// 人员类别
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// 学生学号
            /// </summary>
            [NameInMap("studentNumber")]
            [Validation(Required=false)]
            public string StudentNumber { get; set; }

        }

        /// <summary>
        /// 学生在组织状态
        /// </summary>
        [NameInMap("dingMemberStatus")]
        [Validation(Required=false)]
        public string DingMemberStatus { get; set; }

        /// <summary>
        /// 人员拓展信息
        /// </summary>
        [NameInMap("empExtension")]
        [Validation(Required=false)]
        public Dictionary<string, object> EmpExtension { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [NameInMap("identifyId")]
        [Validation(Required=false)]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 账号是否激活
        /// </summary>
        [NameInMap("isActive")]
        [Validation(Required=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 入学年月
        /// </summary>
        [NameInMap("startYear")]
        [Validation(Required=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [NameInMap("studentName")]
        [Validation(Required=false)]
        public string StudentName { get; set; }

        /// <summary>
        /// unionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
