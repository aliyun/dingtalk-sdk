// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomControlPanelListResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryMeetingRoomControlPanelListResponseBodyResult> Result { get; set; }
        public class QueryMeetingRoomControlPanelListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1WADFxxxxxx</para>
            /// </summary>
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("roomIotConfig")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig> RoomIotConfig { get; set; }
            public class QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("enName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.taoxxxxx.com">https://www.taoxxxxx.com</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>栗子xx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("showTime")]
                [Validation(Required=false)]
                public int? ShowTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("sort")]
                [Validation(Required=false)]
                public int? Sort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.taoxxxxx.com">https://www.taoxxxxx.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
