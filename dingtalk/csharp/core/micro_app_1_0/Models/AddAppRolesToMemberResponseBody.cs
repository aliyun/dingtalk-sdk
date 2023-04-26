// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppRolesToMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AddAppRolesToMemberResponseBodyResult> Result { get; set; }
        public class AddAppRolesToMemberResponseBodyResult : TeaModel {
            [NameInMap("latestScopeVersion")]
            [Validation(Required=false)]
            public long? LatestScopeVersion { get; set; }

            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("subErrorCode")]
            [Validation(Required=false)]
            public string SubErrorCode { get; set; }

            [NameInMap("subErrorMsg")]
            [Validation(Required=false)]
            public string SubErrorMsg { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
