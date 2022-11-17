// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class CreateMeetingRoomRequest : TeaModel {
        /// <summary>
        /// 会议室所属分组id
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

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
        /// 会议室标签
        /// </summary>
        [NameInMap("roomLabelIds")]
        [Validation(Required=false)]
        public List<long?> RoomLabelIds { get; set; }

        /// <summary>
        /// 会议室位置
        /// </summary>
        [NameInMap("roomLocation")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestRoomLocation RoomLocation { get; set; }
        public class CreateMeetingRoomRequestRoomLocation : TeaModel {
            /// <summary>
            /// 位置详细信息
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// 位置标题
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
        /// 会议室状态
        /// </summary>
        [NameInMap("roomStatus")]
        [Validation(Required=false)]
        public int? RoomStatus { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
