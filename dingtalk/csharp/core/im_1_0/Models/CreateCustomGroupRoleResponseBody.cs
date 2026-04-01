// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateCustomGroupRoleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCustomGroupRoleResponseBodyResult Result { get; set; }
        public class CreateCustomGroupRoleResponseBodyResult : TeaModel {
            [NameInMap("openRoleId")]
            [Validation(Required=false)]
            public string OpenRoleId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
