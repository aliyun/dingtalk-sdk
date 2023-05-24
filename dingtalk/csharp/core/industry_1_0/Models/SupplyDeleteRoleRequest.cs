// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyDeleteRoleRequest : TeaModel {
        [NameInMap("isRoleGroup")]
        [Validation(Required=false)]
        public bool? IsRoleGroup { get; set; }

        [NameInMap("roleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
