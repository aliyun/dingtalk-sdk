// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetMachineUserResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMachineUserResponseBodyResult Result { get; set; }
        public class GetMachineUserResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<GetMachineUserResponseBodyResultUserList> UserList { get; set; }
            public class GetMachineUserResponseBodyResultUserList : TeaModel {
                public string UserId { get; set; }
                public string Name { get; set; }
                public bool? HasFace { get; set; }
            }
        };

    }

}
