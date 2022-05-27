// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListUserIndustryRolesResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<ListUserIndustryRolesResponseBodyRoleList> RoleList { get; set; }
        public class ListUserIndustryRolesResponseBodyRoleList : TeaModel {
            /// <summary>
            /// 角色id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 角色名字
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// 行业角色编码
            /// </summary>
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

        }

    }

}
