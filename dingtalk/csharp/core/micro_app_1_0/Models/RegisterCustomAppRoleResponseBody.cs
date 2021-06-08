// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class RegisterCustomAppRoleResponseBody : TeaModel {
        /// <summary>
        /// 角色id
        /// </summary>
        [NameInMap("roleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        /// <summary>
        /// 角色版本号
        /// </summary>
        [NameInMap("scopeVersion")]
        [Validation(Required=false)]
        public long? ScopeVersion { get; set; }

    }

}
