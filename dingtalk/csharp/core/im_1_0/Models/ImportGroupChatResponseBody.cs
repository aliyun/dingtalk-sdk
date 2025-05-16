// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ImportGroupChatResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ImportGroupChatResponseBodyResult Result { get; set; }
        public class ImportGroupChatResponseBodyResult : TeaModel {
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
