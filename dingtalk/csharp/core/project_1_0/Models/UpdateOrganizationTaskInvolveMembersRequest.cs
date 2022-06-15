// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskInvolveMembersRequest : TeaModel {
        /// <summary>
        /// 增加的参与者uid
        /// </summary>
        [NameInMap("addInvolvers")]
        [Validation(Required=false)]
        public List<string> AddInvolvers { get; set; }

        /// <summary>
        /// 删除的参与者uid
        /// </summary>
        [NameInMap("delInvolvers")]
        [Validation(Required=false)]
        public List<string> DelInvolvers { get; set; }

        /// <summary>
        /// 是否禁用动态
        /// </summary>
        [NameInMap("disableActivity")]
        [Validation(Required=false)]
        public bool? DisableActivity { get; set; }

        /// <summary>
        /// 是否禁用通知
        /// </summary>
        [NameInMap("disableNotification")]
        [Validation(Required=false)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// 所有参与者uid
        /// </summary>
        [NameInMap("involveMembers")]
        [Validation(Required=false)]
        public List<string> InvolveMembers { get; set; }

    }

}
