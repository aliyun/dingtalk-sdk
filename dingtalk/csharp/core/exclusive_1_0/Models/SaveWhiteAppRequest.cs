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
        public List<long?> AgentIdList { get; set; }

        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

    }

}
