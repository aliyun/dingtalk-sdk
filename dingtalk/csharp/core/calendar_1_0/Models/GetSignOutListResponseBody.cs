// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetSignOutListResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("users")]
        [Validation(Required=false)]
        public List<GetSignOutListResponseBodyUsers> Users { get; set; }
        public class GetSignOutListResponseBodyUsers : TeaModel {
            [NameInMap("checkOutTime")]
            [Validation(Required=false)]
            public long? CheckOutTime { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
