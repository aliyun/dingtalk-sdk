// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListStudentInfoResponseBody : TeaModel {
        /// <summary>
        /// 学生在组织状态
        /// </summary>
        [NameInMap("dingMemberStatus")]
        [Validation(Required=false)]
        public string DingMemberStatus { get; set; }

        /// <summary>
        /// 账号是否激活
        /// </summary>
        [NameInMap("isActive")]
        [Validation(Required=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 学生信息列表
        /// </summary>
        [NameInMap("studentInfoSimpleList")]
        [Validation(Required=false)]
        public List<CollegeListStudentInfoResponseBodyStudentInfoSimpleList> StudentInfoSimpleList { get; set; }
        public class CollegeListStudentInfoResponseBodyStudentInfoSimpleList : TeaModel {
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

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
