// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMuteStatusResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupMuteMode")]
        [Validation(Required=false)]
        public bool? GroupMuteMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userMuteResult")]
        [Validation(Required=false)]
        public QueryGroupMuteStatusResponseBodyUserMuteResult UserMuteResult { get; set; }
        public class QueryGroupMuteStatusResponseBodyUserMuteResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("muteEndTime")]
            [Validation(Required=false)]
            public long? MuteEndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("muteStartTime")]
            [Validation(Required=false)]
            public long? MuteStartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userMuteMode")]
            [Validation(Required=false)]
            public bool? UserMuteMode { get; set; }

        }

    }

}
