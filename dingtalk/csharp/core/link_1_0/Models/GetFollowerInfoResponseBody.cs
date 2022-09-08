// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetFollowerInfoResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 响应结果
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

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
