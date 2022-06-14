// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateDeviceChatRoomResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateDeviceChatRoomResponseBodyResult Result { get; set; }
        public class CreateDeviceChatRoomResponseBodyResult : TeaModel {
            [NameInMap("chatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }
            [NameInMap("encodedCid")]
            [Validation(Required=false)]
            public string EncodedCid { get; set; }
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
