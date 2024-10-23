// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ListSceneGroupsByTemplateIdResponseBody : TeaModel {
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
