// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateManagementGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateManagementGroupRequestMembers> Members { get; set; }
        public class CreateManagementGroupRequestMembers : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public CreateManagementGroupRequestScope Scope { get; set; }
        public class CreateManagementGroupRequestScope : TeaModel {
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

        }

    }

}
