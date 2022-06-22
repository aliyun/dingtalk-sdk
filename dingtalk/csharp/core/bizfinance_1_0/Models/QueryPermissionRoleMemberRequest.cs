// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryPermissionRoleMemberRequest : TeaModel {
        /// <summary>
        /// 角色的唯一标识列表
        /// </summary>
        [NameInMap("roleCodeList")]
        [Validation(Required=false)]
        public List<string> RoleCodeList { get; set; }

    }

}
