// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetSignInListResponseBody : TeaModel {
        /// <summary>
        /// 翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 签到信息
        /// </summary>
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<GetSignInListResponseBodyUsers> Users { get; set; }
        public class GetSignInListResponseBodyUsers : TeaModel {
            /// <summary>
            /// 签到时间
            /// </summary>
            [NameInMap("checkInTime")]
            [Validation(Required=false)]
            public long? CheckInTime { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
