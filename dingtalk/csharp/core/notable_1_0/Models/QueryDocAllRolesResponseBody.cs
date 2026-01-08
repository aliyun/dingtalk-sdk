// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class QueryDocAllRolesResponseBody : TeaModel {
        [NameInMap("allRoles")]
        [Validation(Required=false)]
        public List<QueryDocAllRolesResponseBodyAllRoles> AllRoles { get; set; }
        public class QueryDocAllRolesResponseBodyAllRoles : TeaModel {
            [NameInMap("members")]
            [Validation(Required=false)]
            public List<QueryDocAllRolesResponseBodyAllRolesMembers> Members { get; set; }
            public class QueryDocAllRolesResponseBodyAllRolesMembers : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberIdBelongOrgId")]
                [Validation(Required=false)]
                public long? MemberIdBelongOrgId { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("role")]
            [Validation(Required=false)]
            public QueryDocAllRolesResponseBodyAllRolesRole Role { get; set; }
            public class QueryDocAllRolesResponseBodyAllRolesRole : TeaModel {
                [NameInMap("flowType")]
                [Validation(Required=false)]
                public string FlowType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("roleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                [NameInMap("subRoles")]
                [Validation(Required=false)]
                public List<QueryDocAllRolesResponseBodyAllRolesRoleSubRoles> SubRoles { get; set; }
                public class QueryDocAllRolesResponseBodyAllRolesRoleSubRoles : TeaModel {
                    [NameInMap("authLevel")]
                    [Validation(Required=false)]
                    public int? AuthLevel { get; set; }

                    [NameInMap("bizType")]
                    [Validation(Required=false)]
                    public int? BizType { get; set; }

                    [NameInMap("config")]
                    [Validation(Required=false)]
                    public string Config { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

            }

        }

        [NameInMap("defaultRole")]
        [Validation(Required=false)]
        public QueryDocAllRolesResponseBodyDefaultRole DefaultRole { get; set; }
        public class QueryDocAllRolesResponseBodyDefaultRole : TeaModel {
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

        }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("systemRoles")]
        [Validation(Required=false)]
        public List<long?> SystemRoles { get; set; }

    }

}
