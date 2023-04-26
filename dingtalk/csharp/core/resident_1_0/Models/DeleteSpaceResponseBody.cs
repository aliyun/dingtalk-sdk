// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class DeleteSpaceResponseBody : TeaModel {
        [NameInMap("delFailedDept")]
        [Validation(Required=false)]
        public List<DeleteSpaceResponseBodyDelFailedDept> DelFailedDept { get; set; }
        public class DeleteSpaceResponseBodyDelFailedDept : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

        }

        [NameInMap("delSuccessCount")]
        [Validation(Required=false)]
        public bool? DelSuccessCount { get; set; }

    }

}
