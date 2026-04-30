// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class BatchGetUserResponseBody : TeaModel {
        [NameInMap("unauthorizedUserIdList")]
        [Validation(Required=false)]
        public List<string> UnauthorizedUserIdList { get; set; }

        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<BatchGetUserResponseBodyUserList> UserList { get; set; }
        public class BatchGetUserResponseBodyUserList : TeaModel {
            [NameInMap("job_number")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("senior")]
            [Validation(Required=false)]
            public bool? Senior { get; set; }

            [NameInMap("state_code")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            [NameInMap("unionid")]
            [Validation(Required=false)]
            public string Unionid { get; set; }

            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

    }

}
