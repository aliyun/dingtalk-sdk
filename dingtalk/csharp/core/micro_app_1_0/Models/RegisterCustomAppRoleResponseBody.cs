// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class RegisterCustomAppRoleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("roleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123123123</para>
        /// </summary>
        [NameInMap("scopeVersion")]
        [Validation(Required=false)]
        public long? ScopeVersion { get; set; }

    }

}
