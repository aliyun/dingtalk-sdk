// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskInvolvemembersRequest : TeaModel {
        /// <summary>
        /// 新增参与者列表。
        /// </summary>
        [NameInMap("addInvolvers")]
        [Validation(Required=false)]
        public List<string> AddInvolvers { get; set; }

        /// <summary>
        /// 移除参与者列表。
        /// </summary>
        [NameInMap("delInvolvers")]
        [Validation(Required=false)]
        public List<string> DelInvolvers { get; set; }

        /// <summary>
        /// 更新任务参与者列表。
        /// </summary>
        [NameInMap("involveMembers")]
        [Validation(Required=false)]
        public List<string> InvolveMembers { get; set; }

    }

}
