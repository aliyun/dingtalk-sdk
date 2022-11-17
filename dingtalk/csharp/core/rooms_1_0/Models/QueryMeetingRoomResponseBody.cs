// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMeetingRoomResponseBodyResult Result { get; set; }
        public class QueryMeetingRoomResponseBodyResult : TeaModel {
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
            /// 会议室分组
            /// </summary>
            [NameInMap("roomGroup")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultRoomGroup RoomGroup { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomGroup : TeaModel {
                /// <summary>
                /// 分组id
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// 分组名称
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// 父分组id
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            /// <summary>
            /// 会议室id
            /// </summary>
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("roomLabels")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomResponseBodyResultRoomLabels> RoomLabels { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomLabels : TeaModel {
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
            public QueryMeetingRoomResponseBodyResultRoomLocation RoomLocation { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomLocation : TeaModel {
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
