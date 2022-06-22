// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryPermissionRoleMemberResponseBody : TeaModel {
        /// <summary>
        /// 角色下的成员MAP
        /// </summary>
        [NameInMap("roleMemberMap")]
        [Validation(Required=false)]
        public Dictionary<string, RoleMemberMapValue> RoleMemberMap { get; set; }

    }

}
