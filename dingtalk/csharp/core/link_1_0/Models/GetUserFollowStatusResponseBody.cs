// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetUserFollowStatusResponseBody : TeaModel {
        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetUserFollowStatusResponseBodyResult Result { get; set; }
        public class GetUserFollowStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// 用户关注服务窗的状态:
            /// FOLLOWED：已关注。
            /// UNFOLLOW：未关注。
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
