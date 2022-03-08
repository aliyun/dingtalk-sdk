// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListAttendeesResponseBody : TeaModel {
        /// <summary>
        /// 参与人
        /// </summary>
        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<ListAttendeesResponseBodyAttendees> Attendees { get; set; }
        public class ListAttendeesResponseBodyAttendees : TeaModel {
            /// <summary>
            /// 用户名
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 回复状态
            /// </summary>
            [NameInMap("responseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }

            /// <summary>
            /// 是否当前用户
            /// </summary>
            [NameInMap("self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }

        }

        /// <summary>
        /// 翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
