// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class AddRecentUserAppListRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("usedAppDetailList")]
        [Validation(Required=false)]
        public List<AddRecentUserAppListRequestUsedAppDetailList> UsedAppDetailList { get; set; }
        public class AddRecentUserAppListRequestUsedAppDetailList : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
