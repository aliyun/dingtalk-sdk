// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetFollowerInfoResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFollowerInfoResponseBodyResult Result { get; set; }
        public class GetFollowerInfoResponseBodyResult : TeaModel {
            [NameInMap("user")]
            [Validation(Required=false)]
            public GetFollowerInfoResponseBodyResultUser User { get; set; }
            public class GetFollowerInfoResponseBodyResultUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
