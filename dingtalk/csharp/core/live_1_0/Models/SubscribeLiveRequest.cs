// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class SubscribeLiveRequest : TeaModel {
        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        [NameInMap("subscribe")]
        [Validation(Required=false)]
        public bool? Subscribe { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
