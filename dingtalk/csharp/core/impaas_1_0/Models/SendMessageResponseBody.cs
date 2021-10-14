// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class SendMessageResponseBody : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("msgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

    }

}
