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
            /// <summary>
            /// 订阅详情列表
            /// </summary>
            [NameInMap("subscribeStatusDTOS")]
            [Validation(Required=false)]
            public List<QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS> SubscribeStatusDTOS { get; set; }
            public class QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS : TeaModel {
                /// <summary>
                /// 直播uuid
                /// </summary>
                [NameInMap("liveId")]
                [Validation(Required=false)]
                public string LiveId { get; set; }

                /// <summary>
                /// 是否订阅 true:订阅 false:非订阅
                /// </summary>
                [NameInMap("subscribe")]
                [Validation(Required=false)]
                public bool? Subscribe { get; set; }

            }

        }

    }

}
