// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class AppendRolePermissionRequest : TeaModel {
        [NameInMap("rolePermissionItemList")]
        [Validation(Required=false)]
        public List<AppendRolePermissionRequestRolePermissionItemList> RolePermissionItemList { get; set; }
        public class AppendRolePermissionRequestRolePermissionItemList : TeaModel {
            [NameInMap("permissionList")]
            [Validation(Required=false)]
            public List<AppendRolePermissionRequestRolePermissionItemListPermissionList> PermissionList { get; set; }
            public class AppendRolePermissionRequestRolePermissionItemListPermissionList : TeaModel {
                [NameInMap("actionIdList")]
                [Validation(Required=false)]
                public List<string> ActionIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/invoice</para>
                /// </summary>
                [NameInMap("resourceIdentity")]
                [Validation(Required=false)]
                public string ResourceIdentity { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>financeManager</para>
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5041234</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
