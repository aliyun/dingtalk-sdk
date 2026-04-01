// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryCustomGroupRolesByUserResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCustomGroupRolesByUserResponseBodyResult Result { get; set; }
        public class QueryCustomGroupRolesByUserResponseBodyResult : TeaModel {
            [NameInMap("groupRoles")]
            [Validation(Required=false)]
            public List<QueryCustomGroupRolesByUserResponseBodyResultGroupRoles> GroupRoles { get; set; }
            public class QueryCustomGroupRolesByUserResponseBodyResultGroupRoles : TeaModel {
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
