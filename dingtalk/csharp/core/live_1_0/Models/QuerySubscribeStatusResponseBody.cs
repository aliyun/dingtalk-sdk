// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QuerySubscribeStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySubscribeStatusResponseBodyResult Result { get; set; }
        public class QuerySubscribeStatusResponseBodyResult : TeaModel {
            [NameInMap("subscribeStatusDTOS")]
            [Validation(Required=false)]
            public List<QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS> SubscribeStatusDTOS { get; set; }
            public class QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS : TeaModel {
                public string LiveId { get; set; }
                public bool? Subscribe { get; set; }
            }
        };

    }

}
