// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class AiVoucherRequest : TeaModel {
        [NameInMap("chatMessages")]
        [Validation(Required=false)]
        public string ChatMessages { get; set; }

        [NameInMap("enableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        [NameInMap("extendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
