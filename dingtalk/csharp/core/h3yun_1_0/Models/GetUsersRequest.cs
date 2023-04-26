// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetUsersRequest : TeaModel {
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("isRecursive")]
        [Validation(Required=false)]
        public bool? IsRecursive { get; set; }

    }

}
