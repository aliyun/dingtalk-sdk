// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class UpdateDingPortalPageScopeRequest : TeaModel {
        /// <summary>
        /// 可见用户列表
        /// </summary>
        [NameInMap("userids")]
        [Validation(Required=false)]
        public List<string> Userids { get; set; }

        /// <summary>
        /// 可见部门列表
        /// </summary>
        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

        /// <summary>
        /// 可见角色列表
        /// </summary>
        [NameInMap("roleIds")]
        [Validation(Required=false)]
        public List<long?> RoleIds { get; set; }

        /// <summary>
        /// 是否全员可见
        /// </summary>
        [NameInMap("allVisible")]
        [Validation(Required=false)]
        public bool? AllVisible { get; set; }

    }

}
