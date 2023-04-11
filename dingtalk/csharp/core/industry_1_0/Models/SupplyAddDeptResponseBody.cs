// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddDeptResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SupplyAddDeptResponseBodyResult Result { get; set; }
        public class SupplyAddDeptResponseBodyResult : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

        }

    }

}
