// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryUserRoleListResponseBody : TeaModel {
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
