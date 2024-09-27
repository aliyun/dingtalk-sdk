// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ListCollegeContactDeptTypeConfigResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListCollegeContactDeptTypeConfigResponseBodyResult> Result { get; set; }
        public class ListCollegeContactDeptTypeConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>contact_class_dept</para>
            /// </summary>
            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>班级</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userDef")]
            [Validation(Required=false)]
            public bool? UserDef { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
