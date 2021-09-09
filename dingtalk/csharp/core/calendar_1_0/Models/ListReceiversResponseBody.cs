// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListReceiversResponseBody : TeaModel {
        /// <summary>
        /// 翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 用户详情
        /// </summary>
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<ListReceiversResponseBodyUsers> Users { get; set; }
        public class ListReceiversResponseBodyUsers : TeaModel {
            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 签到状态
            /// </summary>
            [NameInMap("checkInStatus")]
            [Validation(Required=false)]
            public long? CheckInStatus { get; set; }

            /// <summary>
            /// 签到时间
            /// </summary>
            [NameInMap("checkInTime")]
            [Validation(Required=false)]
            public long? CheckInTime { get; set; }

        }

    }

}
