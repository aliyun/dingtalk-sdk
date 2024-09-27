// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyUpdateRoleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("isRoleGroup")]
        [Validation(Required=false)]
        public bool? IsRoleGroup { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
