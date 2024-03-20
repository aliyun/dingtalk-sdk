// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_interaction_1_0.Models
{
    public class PrepareResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PrepareResponseBodyResult Result { get; set; }
        public class PrepareResponseBodyResult : TeaModel {
            [NameInMap("conversationToken")]
            [Validation(Required=false)]
            public string ConversationToken { get; set; }

        }

    }

}
