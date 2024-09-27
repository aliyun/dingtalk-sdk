// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetMicroAppScopeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMicroAppScopeResponseBodyResult Result { get; set; }
        public class GetMicroAppScopeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("onlyAdminVisible")]
            [Validation(Required=false)]
            public bool? OnlyAdminVisible { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<long?> RoleIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
