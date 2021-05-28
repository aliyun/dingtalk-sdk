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
            /// 角色id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 角色范围最新版本号
            /// </summary>
            [NameInMap("latestScopeVersion")]
            [Validation(Required=false)]
            public long? LatestScopeVersion { get; set; }

            /// <summary>
            /// 角色添加结果，true: 成功，false: 失败
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("subErrorCode")]
            [Validation(Required=false)]
            public string SubErrorCode { get; set; }

            [NameInMap("subErrorMsg")]
            [Validation(Required=false)]
            public string SubErrorMsg { get; set; }

        }

    }

}
