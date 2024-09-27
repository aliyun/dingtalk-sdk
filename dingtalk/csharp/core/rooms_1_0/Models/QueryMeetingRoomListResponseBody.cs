// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryMeetingRoomListResponseBodyResult> Result { get; set; }
        public class QueryMeetingRoomListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding994a046bca84545935c2f4657eb6378f</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxIsvRoomId</para>
            /// </summary>
            [NameInMap("isvRoomId")]
            [Validation(Required=false)]
            public string IsvRoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("roomCapacity")]
            [Validation(Required=false)]
            public int? RoomCapacity { get; set; }

            [NameInMap("roomGroup")]
            [Validation(Required=false)]
            public QueryMeetingRoomListResponseBodyResultRoomGroup RoomGroup { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试分组</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</para>
            /// </summary>
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("roomLabels")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomListResponseBodyResultRoomLabels> RoomLabels { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomLabels : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

            }

            [NameInMap("roomLocation")]
            [Validation(Required=false)]
            public QueryMeetingRoomListResponseBodyResultRoomLocation RoomLocation { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx市xx区xx街道xx号</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx公司</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试会议室</para>
            /// </summary>
            [NameInMap("roomName")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg">https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg</a></para>
            /// </summary>
            [NameInMap("roomPicture")]
            [Validation(Required=false)]
            public string RoomPicture { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01224148194623278976</para>
            /// </summary>
            [NameInMap("roomStaffId")]
            [Validation(Required=false)]
            public string RoomStaffId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.全员可用 1.仅管理员可用</para>
            /// </summary>
            [NameInMap("roomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

        }

    }

}
