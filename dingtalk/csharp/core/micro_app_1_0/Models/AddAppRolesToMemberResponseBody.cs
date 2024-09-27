// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppRolesToMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AddAppRolesToMemberResponseBodyResult> Result { get; set; }
        public class AddAppRolesToMemberResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("latestScopeVersion")]
            [Validation(Required=false)]
            public long? LatestScopeVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userNoPrivilegeToManageApp</para>
            /// </summary>
            [NameInMap("subErrorCode")]
            [Validation(Required=false)]
            public string SubErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>传入的角色范围数据版本号不合法</para>
            /// </summary>
            [NameInMap("subErrorMsg")]
            [Validation(Required=false)]
            public string SubErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
