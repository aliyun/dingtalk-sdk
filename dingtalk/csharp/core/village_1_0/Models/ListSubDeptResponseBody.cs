// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubDeptResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSubDeptResponseBodyResult> Result { get; set; }
        public class ListSubDeptResponseBodyResult : TeaModel {
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
