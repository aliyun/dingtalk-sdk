// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListManagementGroupsResponseBody : TeaModel {
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<ListManagementGroupsResponseBodyGroups> Groups { get; set; }
        public class ListManagementGroupsResponseBodyGroups : TeaModel {
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("members")]
            [Validation(Required=false)]
            public List<ListManagementGroupsResponseBodyGroupsMembers> Members { get; set; }
            public class ListManagementGroupsResponseBodyGroupsMembers : TeaModel {
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            [NameInMap("resourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public ListManagementGroupsResponseBodyGroupsScope Scope { get; set; }
            public class ListManagementGroupsResponseBodyGroupsScope : TeaModel {
                [NameInMap("deptIds")]
                [Validation(Required=false)]
                public List<long?> DeptIds { get; set; }

                [NameInMap("scopeType")]
                [Validation(Required=false)]
                public int? ScopeType { get; set; }

            }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
