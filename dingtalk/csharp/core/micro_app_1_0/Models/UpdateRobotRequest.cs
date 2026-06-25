// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class UpdateRobotRequest : TeaModel {
        [NameInMap("brief")]
        [Validation(Required=false)]
        public string Brief { get; set; }

        [NameInMap("chatBotEventUrl")]
        [Validation(Required=false)]
        public string ChatBotEventUrl { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("iconMediaId")]
        [Validation(Required=false)]
        public string IconMediaId { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("outgoingUrl")]
        [Validation(Required=false)]
        public string OutgoingUrl { get; set; }

        [NameInMap("unifiedAppId")]
        [Validation(Required=false)]
        public string UnifiedAppId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
