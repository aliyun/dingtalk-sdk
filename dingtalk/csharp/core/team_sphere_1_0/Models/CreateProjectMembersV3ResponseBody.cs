// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class CreateProjectMembersV3ResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CreateProjectMembersV3ResponseBodyResult> Result { get; set; }
        public class CreateProjectMembersV3ResponseBodyResult : TeaModel {
            [NameInMap("boundToObjectId")]
            [Validation(Required=false)]
            public string BoundToObjectId { get; set; }

            [NameInMap("boundToObjectType")]
            [Validation(Required=false)]
            public string BoundToObjectType { get; set; }

            [NameInMap("joined")]
            [Validation(Required=false)]
            public string Joined { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
