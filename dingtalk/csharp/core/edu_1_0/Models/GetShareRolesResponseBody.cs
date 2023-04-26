// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetShareRolesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetShareRolesResponseBodyResult> Result { get; set; }
        public class GetShareRolesResponseBodyResult : TeaModel {
            [NameInMap("shareRoleCode")]
            [Validation(Required=false)]
            public string ShareRoleCode { get; set; }

            [NameInMap("shareRoleName")]
            [Validation(Required=false)]
            public string ShareRoleName { get; set; }

        }

    }

}
