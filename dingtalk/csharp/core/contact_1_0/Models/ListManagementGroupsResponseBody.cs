// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListManagementGroupsResponseBody : TeaModel {
        /// <summary>
        /// 管理组列表
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<ListManagementGroupsResponseBodyGroups> Groups { get; set; }
        public class ListManagementGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// 管理组id
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// 管理组名
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 成员
            /// </summary>
            [NameInMap("members")]
            [Validation(Required=false)]
            public List<ListManagementGroupsResponseBodyGroupsMembers> Members { get; set; }
            public class ListManagementGroupsResponseBodyGroupsMembers : TeaModel {
                /// <summary>
                /// 成员id
                /// </summary>
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// 成员类型
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            /// <summary>
            /// 资源列表
            /// </summary>
            [NameInMap("resourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// 管理范围
            /// </summary>
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
            };

        }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次读取的位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
