// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class RegisterCustomAppRoleRequest : TeaModel {
        /// <summary>
        /// 是否拥有管理角色的权限，可不传，默认false
        /// </summary>
        [NameInMap("canManageRole")]
        [Validation(Required=false)]
        public bool? CanManageRole { get; set; }

        /// <summary>
        /// 执行用户userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
