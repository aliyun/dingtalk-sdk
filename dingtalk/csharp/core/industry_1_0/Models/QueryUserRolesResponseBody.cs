// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserRolesResponseBody : TeaModel {
        /// <summary>
        /// 扩展属性
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserRolesResponseBodyContent> Content { get; set; }
        public class QueryUserRolesResponseBodyContent : TeaModel {
            /// <summary>
            /// 角色编码
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
