// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class UpdateProjectMemberRoleV3ResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<UpdateProjectMemberRoleV3ResponseBodyResult> Result { get; set; }
        public class UpdateProjectMemberRoleV3ResponseBodyResult : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
