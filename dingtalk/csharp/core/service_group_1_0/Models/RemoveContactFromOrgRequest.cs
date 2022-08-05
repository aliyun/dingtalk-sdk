// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class RemoveContactFromOrgRequest : TeaModel {
        /// <summary>
        /// 开放联系人uinionId
        /// </summary>
        [NameInMap("contactUnionId")]
        [Validation(Required=false)]
        public string ContactUnionId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
