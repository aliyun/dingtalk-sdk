// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class UpdateMeetingRoomRequest : TeaModel {
        [NameInMap("enableCycleReservation")]
        [Validation(Required=false)]
        public bool? EnableCycleReservation { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("isvRoomId")]
        [Validation(Required=false)]
        public string IsvRoomId { get; set; }

        [NameInMap("reservationAuthority")]
        [Validation(Required=false)]
        public UpdateMeetingRoomRequestReservationAuthority ReservationAuthority { get; set; }
        public class UpdateMeetingRoomRequestReservationAuthority : TeaModel {
            [NameInMap("authorizedMembers")]
            [Validation(Required=false)]
            public List<UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers> AuthorizedMembers { get; set; }
            public class UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers : TeaModel {
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

        }

        [NameInMap("roomCapacity")]
        [Validation(Required=false)]
        public int? RoomCapacity { get; set; }

        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("roomLabelIds")]
        [Validation(Required=false)]
        public List<long?> RoomLabelIds { get; set; }

        [NameInMap("roomLocation")]
        [Validation(Required=false)]
        public UpdateMeetingRoomRequestRoomLocation RoomLocation { get; set; }
        public class UpdateMeetingRoomRequestRoomLocation : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("roomName")]
        [Validation(Required=false)]
        public string RoomName { get; set; }

        [NameInMap("roomPicture")]
        [Validation(Required=false)]
        public string RoomPicture { get; set; }

        [NameInMap("roomStatus")]
        [Validation(Required=false)]
        public int? RoomStatus { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
