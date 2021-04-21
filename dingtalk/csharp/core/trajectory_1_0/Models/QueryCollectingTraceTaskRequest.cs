// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrajectory_1_0.Models
{
    public class QueryCollectingTraceTaskRequest : TeaModel {
        /// <summary>
        /// 员工用户ID
        /// </summary>
        [NameInMap("staffIds")]
        [Validation(Required=false)]
        public List<string> StaffIds { get; set; }

    }

}
