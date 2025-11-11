// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_one_1_0.Models
{
    public class PushFeedResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public PushFeedResponseBodyResult Result { get; set; }
        public class PushFeedResponseBodyResult : TeaModel {
            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

        }

    }

}
