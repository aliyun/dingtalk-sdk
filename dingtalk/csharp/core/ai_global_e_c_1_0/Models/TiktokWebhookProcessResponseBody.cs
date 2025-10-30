// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class TiktokWebhookProcessResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("omniChannelTiktokWebhookRsp")]
        [Validation(Required=false)]
        public TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp OmniChannelTiktokWebhookRsp { get; set; }
        public class TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
