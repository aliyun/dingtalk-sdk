// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetMicroAppScopeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMicroAppScopeResponseBodyResult Result { get; set; }
        public class GetMicroAppScopeResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("onlyAdminVisible")]
            [Validation(Required=false)]
            public bool? OnlyAdminVisible { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<long?> RoleIds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
