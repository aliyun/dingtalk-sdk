// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListRoleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SupplyListRoleResponseBodyResult> Result { get; set; }
        public class SupplyListRoleResponseBodyResult : TeaModel {
            [NameInMap("isRoleGroup")]
            [Validation(Required=false)]
            public bool? IsRoleGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>老板</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

    }

}
