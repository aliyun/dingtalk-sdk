// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryCustomGroupRolesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCustomGroupRolesResponseBodyResult Result { get; set; }
        public class QueryCustomGroupRolesResponseBodyResult : TeaModel {
            [NameInMap("groupRoles")]
            [Validation(Required=false)]
            public List<QueryCustomGroupRolesResponseBodyResultGroupRoles> GroupRoles { get; set; }
            public class QueryCustomGroupRolesResponseBodyResultGroupRoles : TeaModel {
                [NameInMap("openRoleId")]
                [Validation(Required=false)]
                public string OpenRoleId { get; set; }

                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
