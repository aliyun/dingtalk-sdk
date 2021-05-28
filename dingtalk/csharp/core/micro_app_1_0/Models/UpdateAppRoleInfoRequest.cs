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
        /// 新角色名称
        /// </summary>
        [NameInMap("newRoleName")]
        [Validation(Required=false)]
        public string NewRoleName { get; set; }

    }

}
