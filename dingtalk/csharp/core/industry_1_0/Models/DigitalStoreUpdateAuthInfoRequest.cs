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
                /// <summary>
                /// <b>Example:</b>
                /// <para>区域督导</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("sourceRoleId")]
                [Validation(Required=false)]
                public string SourceRoleId { get; set; }

            }

            [NameInMap("userAuthList")]
            [Validation(Required=false)]
            public List<DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList> UserAuthList { get; set; }
            public class DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8733901123</para>
                /// </summary>
                [NameInMap("dingDeptId")]
                [Validation(Required=false)]
                public string DingDeptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>998383831</para>
                /// </summary>
                [NameInMap("sourceDeptId")]
                [Validation(Required=false)]
                public string SourceDeptId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0998182231</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
