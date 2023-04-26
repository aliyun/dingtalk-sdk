// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectMemebersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetProjectMemebersResponseBodyResult> Result { get; set; }
        public class GetProjectMemebersResponseBodyResult : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            [Obsolete]
            public string MemberId { get; set; }

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
