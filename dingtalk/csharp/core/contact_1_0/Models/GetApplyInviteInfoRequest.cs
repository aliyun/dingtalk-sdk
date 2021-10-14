// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetApplyInviteInfoRequest : TeaModel {
        /// <summary>
        /// 获取部门邀请链接的部门ID
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 邀请者userId
        /// </summary>
        [NameInMap("inviterUserId")]
        [Validation(Required=false)]
        public string InviterUserId { get; set; }

    }

}
