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
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deviceUnionIds")]
            [Validation(Required=false)]
            public List<string> DeviceUnionIds { get; set; }

            [NameInMap("enableCycleReservation")]
            [Validation(Required=false)]
            public bool? EnableCycleReservation { get; set; }

            [NameInMap("isvRoomId")]
            [Validation(Required=false)]
            public string IsvRoomId { get; set; }

            [NameInMap("reservationAuthority")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultReservationAuthority ReservationAuthority { get; set; }
            public class QueryMeetingRoomResponseBodyResultReservationAuthority : TeaModel {
                [NameInMap("authorizedMembers")]
                [Validation(Required=false)]
                public List<QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers> AuthorizedMembers { get; set; }
                public class QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers : TeaModel {
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

            [NameInMap("roomGroup")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultRoomGroup RoomGroup { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomGroup : TeaModel {
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("parentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

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

            [NameInMap("roomLocation")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultRoomLocation RoomLocation { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomLocation : TeaModel {
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

            [NameInMap("roomStaffId")]
            [Validation(Required=false)]
            public string RoomStaffId { get; set; }

            [NameInMap("roomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

        }

    }

}
