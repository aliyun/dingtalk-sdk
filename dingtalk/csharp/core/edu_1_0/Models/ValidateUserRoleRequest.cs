// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ValidateUserRoleRequest : TeaModel {
        /// <summary>
        /// 时间阈值，查询在此时间之前的用户角色信息
        /// </summary>
        [NameInMap("timeThreshold")]
        [Validation(Required=false)]
        public long? TimeThreshold { get; set; }

        /// <summary>
        /// 用户的uionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
