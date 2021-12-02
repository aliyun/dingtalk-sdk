// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class CreateJsapiTicketRequest : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        [NameInMap("dingOauthAppId")]
        [Validation(Required=false)]
        public long? DingOauthAppId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public int? DingTokenGrantType { get; set; }

    }

}
