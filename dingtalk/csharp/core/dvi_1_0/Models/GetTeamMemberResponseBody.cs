// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetTeamMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTeamMemberResponseBodyResult Result { get; set; }
        public class GetTeamMemberResponseBodyResult : TeaModel {
            [NameInMap("admins")]
            [Validation(Required=false)]
            public List<GetTeamMemberResponseBodyResultAdmins> Admins { get; set; }
            public class GetTeamMemberResponseBodyResultAdmins : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("depts")]
            [Validation(Required=false)]
            public List<GetTeamMemberResponseBodyResultDepts> Depts { get; set; }
            public class GetTeamMemberResponseBodyResultDepts : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("members")]
            [Validation(Required=false)]
            public List<GetTeamMemberResponseBodyResultMembers> Members { get; set; }
            public class GetTeamMemberResponseBodyResultMembers : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
