// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class IsvCardEventPushRequest : TeaModel {
        [NameInMap("eventParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> EventParams { get; set; }

        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("isvCardId")]
        [Validation(Required=false)]
        public string IsvCardId { get; set; }

        [NameInMap("isvToken")]
        [Validation(Required=false)]
        public string IsvToken { get; set; }

        [NameInMap("isvUid")]
        [Validation(Required=false)]
        public string IsvUid { get; set; }

    }

}
