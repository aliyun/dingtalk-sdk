// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddMemberToAppRoleRequest : TeaModel {
        /// <summary>
        /// 部门id列表
        /// </summary>
        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        /// <summary>
        /// 执行用户userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 角色范围版本号
        /// </summary>
        [NameInMap("scopeVersion")]
        [Validation(Required=false)]
        public long? ScopeVersion { get; set; }

        /// <summary>
        /// 员工userId列表
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
