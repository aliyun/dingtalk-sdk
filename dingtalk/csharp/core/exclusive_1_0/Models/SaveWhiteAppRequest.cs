// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveWhiteAppRequest : TeaModel {
        [NameInMap("agentIdList")]
        [Validation(Required=false)]
        [Obsolete]
        public List<long?> AgentIdList { get; set; }

        [NameInMap("agentIdMap")]
        [Validation(Required=false)]
        public string AgentIdMap { get; set; }

        [NameInMap("operation")]
        [Validation(Required=false)]
        [Obsolete]
        public string Operation { get; set; }

    }

}
