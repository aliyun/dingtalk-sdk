// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class DeleteProjectMembersV3ResponseBody : TeaModel {
        [NameInMap("errors")]
        [Validation(Required=false)]
        public List<DeleteProjectMembersV3ResponseBodyErrors> Errors { get; set; }
        public class DeleteProjectMembersV3ResponseBodyErrors : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<string> Result { get; set; }

    }

}
