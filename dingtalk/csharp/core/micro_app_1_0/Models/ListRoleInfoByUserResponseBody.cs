// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class ListRoleInfoByUserResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRoleInfoByUserResponseBodyResult> Result { get; set; }
        public class ListRoleInfoByUserResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否拥有角色管理权限，默认false
            /// </summary>
            [NameInMap("canManageRole")]
            [Validation(Required=false)]
            public bool? CanManageRole { get; set; }

            /// <summary>
            /// 角色id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
