// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class SetMicroAppScopeRequest : TeaModel {
        /// <summary>
        /// 增加的可见部门
        /// </summary>
        [NameInMap("addDeptIds")]
        [Validation(Required=false)]
        public List<long?> AddDeptIds { get; set; }

        /// <summary>
        /// 增加的可见角色
        /// </summary>
        [NameInMap("addRoleIds")]
        [Validation(Required=false)]
        public List<long?> AddRoleIds { get; set; }

        /// <summary>
        /// 增加的可见用户
        /// </summary>
        [NameInMap("addUserIds")]
        [Validation(Required=false)]
        public List<string> AddUserIds { get; set; }

        /// <summary>
        /// 删除的可见角色
        /// </summary>
        [NameInMap("ddUserIds")]
        [Validation(Required=false)]
        public List<long?> DdUserIds { get; set; }

        /// <summary>
        /// 删除的可见部门
        /// </summary>
        [NameInMap("delDeptIds")]
        [Validation(Required=false)]
        public List<long?> DelDeptIds { get; set; }

        /// <summary>
        /// 删除的可见用户
        /// </summary>
        [NameInMap("delUserIds")]
        [Validation(Required=false)]
        public List<string> DelUserIds { get; set; }

        /// <summary>
        /// 是否管理员可见
        /// </summary>
        [NameInMap("onlyAdminVisible")]
        [Validation(Required=false)]
        public bool? OnlyAdminVisible { get; set; }

    }

}
