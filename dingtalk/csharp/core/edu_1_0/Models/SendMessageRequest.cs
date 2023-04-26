// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("fromUserId")]
        [Validation(Required=false)]
        public string FromUserId { get; set; }

        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        [NameInMap("toUserIdList")]
        [Validation(Required=false)]
        public List<string> ToUserIdList { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
