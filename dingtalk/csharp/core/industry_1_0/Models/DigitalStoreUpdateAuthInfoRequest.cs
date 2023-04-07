// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreUpdateAuthInfoRequest : TeaModel {
        [NameInMap("updateUserList")]
        [Validation(Required=false)]
        public List<DigitalStoreUpdateAuthInfoRequestUpdateUserList> UpdateUserList { get; set; }
        public class DigitalStoreUpdateAuthInfoRequestUpdateUserList : TeaModel {
            [NameInMap("roleList")]
            [Validation(Required=false)]
            public List<DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList> RoleList { get; set; }
            public class DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList : TeaModel {
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("sourceRoleId")]
                [Validation(Required=false)]
                public string SourceRoleId { get; set; }

            }

            [NameInMap("userAuthList")]
            [Validation(Required=false)]
            public List<DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList> UserAuthList { get; set; }
            public class DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList : TeaModel {
                [NameInMap("dingDeptId")]
                [Validation(Required=false)]
                public string DingDeptId { get; set; }

                [NameInMap("sourceDeptId")]
                [Validation(Required=false)]
                public string SourceDeptId { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
