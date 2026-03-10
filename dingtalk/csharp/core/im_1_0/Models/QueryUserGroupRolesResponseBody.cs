// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUserGroupRolesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserGroupRolesResponseBodyResult Result { get; set; }
        public class QueryUserGroupRolesResponseBodyResult : TeaModel {
            [NameInMap("groupRoles")]
            [Validation(Required=false)]
            public List<QueryUserGroupRolesResponseBodyResultGroupRoles> GroupRoles { get; set; }
            public class QueryUserGroupRolesResponseBodyResultGroupRoles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rolexxxxxxx</para>
                /// </summary>
                [NameInMap("openRoleId")]
                [Validation(Required=false)]
                public string OpenRoleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>负责人</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
