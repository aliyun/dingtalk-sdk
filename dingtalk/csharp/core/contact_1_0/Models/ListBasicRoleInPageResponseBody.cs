// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListBasicRoleInPageResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListBasicRoleInPageResponseBodyList> List { get; set; }
        public class ListBasicRoleInPageResponseBodyList : TeaModel {
            [NameInMap("openAction")]
            [Validation(Required=false)]
            public ListBasicRoleInPageResponseBodyListOpenAction OpenAction { get; set; }
            public class ListBasicRoleInPageResponseBodyListOpenAction : TeaModel {
                [NameInMap("actionIds")]
                [Validation(Required=false)]
                public List<string> ActionIds { get; set; }
                [NameInMap("openCondition")]
                [Validation(Required=false)]
                public ListBasicRoleInPageResponseBodyListOpenActionOpenCondition OpenCondition { get; set; }
                public class ListBasicRoleInPageResponseBodyListOpenActionOpenCondition : TeaModel {
                    [NameInMap("openContactScope")]
                    [Validation(Required=false)]
                    public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope OpenContactScope { get; set; }
                    public class ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope : TeaModel {
                        [NameInMap("deptIds")]
                        [Validation(Required=false)]
                        public List<long?> DeptIds { get; set; }
                        [NameInMap("includeMemberDepts")]
                        [Validation(Required=false)]
                        public bool? IncludeMemberDepts { get; set; }
                        [NameInMap("includeSelfManageDepts")]
                        [Validation(Required=false)]
                        public bool? IncludeSelfManageDepts { get; set; }
                        [NameInMap("userIds")]
                        [Validation(Required=false)]
                        public List<string> UserIds { get; set; }
                    };

                }
            };

            [NameInMap("openMembers")]
            [Validation(Required=false)]
            public List<ListBasicRoleInPageResponseBodyListOpenMembers> OpenMembers { get; set; }
            public class ListBasicRoleInPageResponseBodyListOpenMembers : TeaModel {
                [NameInMap("belongCorpId")]
                [Validation(Required=false)]
                public string BelongCorpId { get; set; }

                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

                [NameInMap("operateUserId")]
                [Validation(Required=false)]
                public string OperateUserId { get; set; }

            }

            [NameInMap("openResources")]
            [Validation(Required=false)]
            public List<string> OpenResources { get; set; }

            [NameInMap("openRoleId")]
            [Validation(Required=false)]
            public string OpenRoleId { get; set; }

            [NameInMap("openRoleName")]
            [Validation(Required=false)]
            public string OpenRoleName { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
