// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateManagementGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateManagementGroupRequestMembers> Members { get; set; }
        public class CreateManagementGroupRequestMembers : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public CreateManagementGroupRequestScope Scope { get; set; }
        public class CreateManagementGroupRequestScope : TeaModel {
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

}
