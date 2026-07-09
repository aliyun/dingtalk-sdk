// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateUserGroupResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateUserGroupResponseBodyResult Result { get; set; }
        public class CreateUserGroupResponseBodyResult : TeaModel {
            [NameInMap("groupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

        }

    }

}
