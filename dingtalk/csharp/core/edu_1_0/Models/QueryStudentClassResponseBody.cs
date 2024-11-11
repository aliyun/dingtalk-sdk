// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryStudentClassResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryStudentClassResponseBodyResult Result { get; set; }
        public class QueryStudentClassResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>classIdxxx</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("classType")]
            [Validation(Required=false)]
            public int? ClassType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ISV_XXX</para>
            /// </summary>
            [NameInMap("isvCode")]
            [Validation(Required=false)]
            public string IsvCode { get; set; }

            [NameInMap("studentList")]
            [Validation(Required=false)]
            public List<QueryStudentClassResponseBodyResultStudentList> StudentList { get; set; }
            public class QueryStudentClassResponseBodyResultStudentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;&quot;}</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>小明</para>
                /// </summary>
                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>studentxxx</para>
                /// </summary>
                [NameInMap("studentUserId")]
                [Validation(Required=false)]
                public string StudentUserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
