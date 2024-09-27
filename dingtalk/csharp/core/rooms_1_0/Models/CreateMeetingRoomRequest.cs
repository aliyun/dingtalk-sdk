// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class CreateMeetingRoomRequest : TeaModel {
        [NameInMap("enableCycleReservation")]
        [Validation(Required=false)]
        public bool? EnableCycleReservation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxIsvRoomId</para>
        /// </summary>
        [NameInMap("isvRoomId")]
        [Validation(Required=false)]
        public string IsvRoomId { get; set; }

        [NameInMap("reservationAuthority")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestReservationAuthority ReservationAuthority { get; set; }
        public class CreateMeetingRoomRequestReservationAuthority : TeaModel {
            [NameInMap("authorizedMembers")]
            [Validation(Required=false)]
            public List<CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers> AuthorizedMembers { get; set; }
            public class CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>lPHhSZDLXXXXXXpBlC9lxLwiEiE</para>
                /// </summary>
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("roomCapacity")]
        [Validation(Required=false)]
        public int? RoomCapacity { get; set; }

        [NameInMap("roomLabelIds")]
        [Validation(Required=false)]
        public List<long?> RoomLabelIds { get; set; }

        [NameInMap("roomLocation")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestRoomLocation RoomLocation { get; set; }
        public class CreateMeetingRoomRequestRoomLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xx市xx区xx路xx号</para>
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
        /// <para>This parameter is required.</para>
        /// 
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.全员可用 1.仅管理员可用</para>
        /// </summary>
        [NameInMap("roomStatus")]
        [Validation(Required=false)]
        public int? RoomStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
