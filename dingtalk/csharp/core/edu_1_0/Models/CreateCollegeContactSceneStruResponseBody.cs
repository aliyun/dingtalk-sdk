// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateCollegeContactSceneStruResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCollegeContactSceneStruResponseBodyResult Result { get; set; }
        public class CreateCollegeContactSceneStruResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("struId")]
            [Validation(Required=false)]
            public long? StruId { get; set; }

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
