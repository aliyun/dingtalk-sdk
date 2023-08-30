// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class SendMessageTipResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SendMessageTipResponseBodyResult Result { get; set; }
        public class SendMessageTipResponseBodyResult : TeaModel {
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("cardInstanceId")]
            [Validation(Required=false)]
            public string CardInstanceId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
