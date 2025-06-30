// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetRoleDetailByIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRoleDetailByIdResponseBodyResult Result { get; set; }
        public class GetRoleDetailByIdResponseBodyResult : TeaModel {
            [NameInMap("canModifyOwners")]
            [Validation(Required=false)]
            public object CanModifyOwners { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("memberTotalCount")]
            [Validation(Required=false)]
            public int? MemberTotalCount { get; set; }

            [NameInMap("members")]
            [Validation(Required=false)]
            public GetRoleDetailByIdResponseBodyResultMembers Members { get; set; }
            public class GetRoleDetailByIdResponseBodyResultMembers : TeaModel {
                [NameInMap("currentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentUuid")]
            [Validation(Required=false)]
            public string ParentUuid { get; set; }

            [NameInMap("roleUuid")]
            [Validation(Required=false)]
            public string RoleUuid { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
