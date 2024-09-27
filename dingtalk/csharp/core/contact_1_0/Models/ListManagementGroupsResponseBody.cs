// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListManagementGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<ListManagementGroupsResponseBodyGroups> Groups { get; set; }
        public class ListManagementGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rolexxx</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>财务管理</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("members")]
            [Validation(Required=false)]
            public List<ListManagementGroupsResponseBodyGroupsMembers> Members { get; set; }
            public class ListManagementGroupsResponseBodyGroupsMembers : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WB001</para>
                /// </summary>
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

            [NameInMap("resourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public ListManagementGroupsResponseBodyGroupsScope Scope { get; set; }
            public class ListManagementGroupsResponseBodyGroupsScope : TeaModel {
                [NameInMap("deptIds")]
                [Validation(Required=false)]
                public List<long?> DeptIds { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:全公司 2:所在部门 3:指定部门</para>
                /// </summary>
                [NameInMap("scopeType")]
                [Validation(Required=false)]
                public int? ScopeType { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
