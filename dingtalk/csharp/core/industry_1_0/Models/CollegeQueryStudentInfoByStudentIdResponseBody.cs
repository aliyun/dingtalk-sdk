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
            /// <summary>
            /// <b>Example:</b>
            /// <para>01123</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>student</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mf1922051</para>
            /// </summary>
            [NameInMap("studentNumber")]
            [Validation(Required=false)]
            public string StudentNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("dingMemberStatus")]
        [Validation(Required=false)]
        public string DingMemberStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”city“:&quot;Beijing&quot;</para>
        /// </summary>
        [NameInMap("empExtension")]
        [Validation(Required=false)]
        public Dictionary<string, object> EmpExtension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>male</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11019xxxxxx0001</para>
        /// </summary>
        [NameInMap("identifyId")]
        [Validation(Required=false)]
        public string IdentifyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isActive")]
        [Validation(Required=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2015</para>
        /// </summary>
        [NameInMap("startYear")]
        [Validation(Required=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("studentName")]
        [Validation(Required=false)]
        public string StudentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111111</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0324124</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
