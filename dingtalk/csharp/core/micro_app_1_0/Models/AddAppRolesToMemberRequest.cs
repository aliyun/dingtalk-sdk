// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppRolesToMemberRequest : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<AddAppRolesToMemberRequestRoleList> RoleList { get; set; }
        public class AddAppRolesToMemberRequestRoleList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scopeVersion")]
            [Validation(Required=false)]
            public long? ScopeVersion { get; set; }

        }

    }

}
