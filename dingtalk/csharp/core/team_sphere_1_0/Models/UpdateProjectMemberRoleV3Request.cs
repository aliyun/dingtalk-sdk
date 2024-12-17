// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class UpdateProjectMemberRoleV3Request : TeaModel {
        [NameInMap("roleIds")]
        [Validation(Required=false)]
        public List<string> RoleIds { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
