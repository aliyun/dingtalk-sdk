// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryUserRoleListResponseBody : TeaModel {
        [NameInMap("financeEmpDeptOpenList")]
        [Validation(Required=false)]
        public List<QueryUserRoleListResponseBodyFinanceEmpDeptOpenList> FinanceEmpDeptOpenList { get; set; }
        public class QueryUserRoleListResponseBodyFinanceEmpDeptOpenList : TeaModel {
            [NameInMap("cascadeDeptId")]
            [Validation(Required=false)]
            public string CascadeDeptId { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("superDeptId")]
            [Validation(Required=false)]
            public long? SuperDeptId { get; set; }

        }

        [NameInMap("roleVOList")]
        [Validation(Required=false)]
        public List<QueryUserRoleListResponseBodyRoleVOList> RoleVOList { get; set; }
        public class QueryUserRoleListResponseBodyRoleVOList : TeaModel {
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
