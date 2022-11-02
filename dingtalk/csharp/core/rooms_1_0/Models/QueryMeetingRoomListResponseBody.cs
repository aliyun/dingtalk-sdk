// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomListResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下次查询分页标记
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 会议室列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryMeetingRoomListResponseBodyResult> Result { get; set; }
        public class QueryMeetingRoomListResponseBodyResult : TeaModel {
            /// <summary>
            /// 企业corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// isv外部会议室id
            /// </summary>
            [NameInMap("isvRoomId")]
            [Validation(Required=false)]
            public string IsvRoomId { get; set; }

            /// <summary>
            /// 会议室容量
            /// </summary>
            [NameInMap("roomCapacity")]
            [Validation(Required=false)]
            public int? RoomCapacity { get; set; }

            /// <summary>
            /// 会议室id
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

            /// <summary>
            /// 会议室位置
            /// </summary>
            [NameInMap("roomLocation")]
            [Validation(Required=false)]
            public QueryMeetingRoomListResponseBodyResultRoomLocation RoomLocation { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomLocation : TeaModel {
                /// <summary>
                /// 位置详细信息
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// 位置名称
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// 会议室名称
            /// </summary>
            [NameInMap("roomName")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            /// <summary>
            /// 会议室图片
            /// </summary>
            [NameInMap("roomPicture")]
            [Validation(Required=false)]
            public string RoomPicture { get; set; }

            /// <summary>
            /// 会议室staffId
            /// </summary>
            [NameInMap("roomStaffId")]
            [Validation(Required=false)]
            public string RoomStaffId { get; set; }

            /// <summary>
            /// 会议室状态
            /// </summary>
            [NameInMap("roomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

        }

    }

}
