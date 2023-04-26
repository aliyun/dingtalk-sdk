// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetAuthTokenRequest : TeaModel {
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public long? EffectiveTime { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("serverId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        [NameInMap("serverName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

    }

}
