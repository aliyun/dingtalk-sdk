// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetAppRoleScopeByRoleIdResponseBody : TeaModel {
        /// <summary>
        /// 角色名称
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [NameInMap("roleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        /// <summary>
        /// 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        /// <summary>
        /// 员工userId列表
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// 角色范围版本号
        /// </summary>
        [NameInMap("scopeVersion")]
        [Validation(Required=false)]
        public string ScopeVersion { get; set; }

    }

}
