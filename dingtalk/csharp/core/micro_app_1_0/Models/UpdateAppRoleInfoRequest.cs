// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class UpdateAppRoleInfoRequest : TeaModel {
        /// <summary>
        /// 执行用户userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 变更角色名称，可不传，不传则不变
        /// </summary>
        [NameInMap("newRoleName")]
        [Validation(Required=false)]
        public string NewRoleName { get; set; }

        /// <summary>
        /// 变更角色管理权限，可不传，不传则不变
        /// </summary>
        [NameInMap("canManageRole")]
        [Validation(Required=false)]
        public bool? CanManageRole { get; set; }

    }

}
