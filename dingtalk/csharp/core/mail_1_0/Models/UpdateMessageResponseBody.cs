// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class UpdateMessageResponseBody : TeaModel {
        [NameInMap("message")]
        [Validation(Required=false)]
        public Message Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
