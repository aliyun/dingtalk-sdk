// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetTaskStudentListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("studentList")]
        [Validation(Required=false)]
        public List<GetTaskStudentListResponseBodyStudentList> StudentList { get; set; }
        public class GetTaskStudentListResponseBodyStudentList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("sexuality")]
            [Validation(Required=false)]
            public string Sexuality { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>675656</para>
            /// </summary>
            [NameInMap("studentId")]
            [Validation(Required=false)]
            public long? StudentId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4240028</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
