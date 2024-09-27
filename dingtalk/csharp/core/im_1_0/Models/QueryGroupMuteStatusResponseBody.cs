// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMuteStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("groupMuteMode")]
        [Validation(Required=false)]
        public bool? GroupMuteMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userMuteResult")]
        [Validation(Required=false)]
        public QueryGroupMuteStatusResponseBodyUserMuteResult UserMuteResult { get; set; }
        public class QueryGroupMuteStatusResponseBodyUserMuteResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645315682000</para>
            /// </summary>
            [NameInMap("muteEndTime")]
            [Validation(Required=false)]
            public long? MuteEndTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645315682000</para>
            /// </summary>
            [NameInMap("muteStartTime")]
            [Validation(Required=false)]
            public long? MuteStartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("userMuteMode")]
            [Validation(Required=false)]
            public bool? UserMuteMode { get; set; }

        }

    }

}
