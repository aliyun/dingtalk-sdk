// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class ManageTeamMemberRequest : TeaModel {
        [NameInMap("addMembers")]
        [Validation(Required=false)]
        public ManageTeamMemberRequestAddMembers AddMembers { get; set; }
        public class ManageTeamMemberRequestAddMembers : TeaModel {
            [NameInMap("adminUserIds")]
            [Validation(Required=false)]
            public List<string> AdminUserIds { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        [NameInMap("removeMembers")]
        [Validation(Required=false)]
        public ManageTeamMemberRequestRemoveMembers RemoveMembers { get; set; }
        public class ManageTeamMemberRequestRemoveMembers : TeaModel {
            [NameInMap("adminUserIds")]
            [Validation(Required=false)]
            public List<string> AdminUserIds { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teamCode")]
        [Validation(Required=false)]
        public string TeamCode { get; set; }

    }

}
