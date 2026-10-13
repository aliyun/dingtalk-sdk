// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetUserGroupResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetUserGroupResponseBodyResult Result { get; set; }
        public class GetUserGroupResponseBodyResult : TeaModel {
            [NameInMap("clientShow")]
            [Validation(Required=false)]
            public bool? ClientShow { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("groupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
