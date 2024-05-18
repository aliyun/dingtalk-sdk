// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkamdp_1_0.Models
{
    public class AmdpEmpRoleDataPushRequest : TeaModel {
        [NameInMap("param")]
        [Validation(Required=false)]
        public List<AmdpEmpRoleDataPushRequestParam> Param { get; set; }
        public class AmdpEmpRoleDataPushRequestParam : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("isDelete")]
            [Validation(Required=false)]
            public string IsDelete { get; set; }

            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
