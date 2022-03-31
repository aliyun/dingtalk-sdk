// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetSignOutListResponseBody : TeaModel {
        /// <summary>
        /// 翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 签退信息
        /// </summary>
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<GetSignOutListResponseBodyUsers> Users { get; set; }
        public class GetSignOutListResponseBodyUsers : TeaModel {
            /// <summary>
            /// 签退时间
            /// </summary>
            [NameInMap("checkOutTime")]
            [Validation(Required=false)]
            public long? CheckOutTime { get; set; }

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
