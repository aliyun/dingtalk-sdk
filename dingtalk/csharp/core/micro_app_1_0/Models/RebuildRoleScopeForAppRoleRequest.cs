// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class RebuildRoleScopeForAppRoleRequest : TeaModel {
        /// <summary>
        /// 执行用户userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 角色范围最新版本号
        /// </summary>
        [NameInMap("scopeVersion")]
        [Validation(Required=false)]
        public long? ScopeVersion { get; set; }

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

    }

}
