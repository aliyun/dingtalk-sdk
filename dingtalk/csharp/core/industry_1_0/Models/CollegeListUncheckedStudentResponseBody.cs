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
            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
