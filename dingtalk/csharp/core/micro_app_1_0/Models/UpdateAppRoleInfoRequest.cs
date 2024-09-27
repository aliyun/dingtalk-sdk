// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class UpdateAppRoleInfoRequest : TeaModel {
        [NameInMap("canManageRole")]
        [Validation(Required=false)]
        public bool? CanManageRole { get; set; }

        [NameInMap("newRoleName")]
        [Validation(Required=false)]
        public string NewRoleName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
