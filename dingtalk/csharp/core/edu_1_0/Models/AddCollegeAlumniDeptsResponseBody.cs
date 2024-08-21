// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddCollegeAlumniDeptsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AddCollegeAlumniDeptsResponseBodyResult> Result { get; set; }
        public class AddCollegeAlumniDeptsResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            [NameInMap("hasSubDept")]
            [Validation(Required=false)]
            public bool? HasSubDept { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("superId")]
            [Validation(Required=false)]
            public long? SuperId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
