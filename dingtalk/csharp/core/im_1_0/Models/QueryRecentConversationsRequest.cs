// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryRecentConversationsRequest : TeaModel {
        [NameInMap("onlyHuman")]
        [Validation(Required=false)]
        public bool? OnlyHuman { get; set; }

        [NameInMap("onlyInnerGroup")]
        [Validation(Required=false)]
        public bool? OnlyInnerGroup { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
