// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class HospitalDataCheckResponseBody : TeaModel {
        [NameInMap("allDeptCount")]
        [Validation(Required=false)]
        public long? AllDeptCount { get; set; }

        [NameInMap("allDeptUserCount")]
        [Validation(Required=false)]
        public long? AllDeptUserCount { get; set; }

        [NameInMap("allGroupCount")]
        [Validation(Required=false)]
        public long? AllGroupCount { get; set; }

        [NameInMap("allGroupUserCount")]
        [Validation(Required=false)]
        public long? AllGroupUserCount { get; set; }

        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public long? DeptCount { get; set; }

        [NameInMap("deptUserCount")]
        [Validation(Required=false)]
        public long? DeptUserCount { get; set; }

        [NameInMap("groupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        [NameInMap("groupUserCount")]
        [Validation(Required=false)]
        public long? GroupUserCount { get; set; }

        [NameInMap("match")]
        [Validation(Required=false)]
        public bool? Match { get; set; }

    }

}
