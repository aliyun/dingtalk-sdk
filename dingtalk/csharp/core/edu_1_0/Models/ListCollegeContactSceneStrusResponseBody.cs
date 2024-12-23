// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ListCollegeContactSceneStrusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListCollegeContactSceneStrusResponseBodyResult> Result { get; set; }
        public class ListCollegeContactSceneStrusResponseBodyResult : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("hasStruFixedDept")]
            [Validation(Required=false)]
            public bool? HasStruFixedDept { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是科研架构简介</para>
            /// </summary>
            [NameInMap("struBrief")]
            [Validation(Required=false)]
            public string StruBrief { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("struId")]
            [Validation(Required=false)]
            public long? StruId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>科研架构</para>
            /// </summary>
            [NameInMap("struName")]
            [Validation(Required=false)]
            public string StruName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stru_research_dept</para>
            /// </summary>
            [NameInMap("struType")]
            [Validation(Required=false)]
            public string StruType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("studentDeptId")]
            [Validation(Required=false)]
            public long? StudentDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("teacherDeptId")]
            [Validation(Required=false)]
            public long? TeacherDeptId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
