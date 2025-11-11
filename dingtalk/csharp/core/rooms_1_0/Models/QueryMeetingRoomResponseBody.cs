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
            /// <b>Example:</b>
            /// <para>ding994a046bca84545935c2f4657eb6378f</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deviceUnionIds")]
            [Validation(Required=false)]
            public List<string> DeviceUnionIds { get; set; }

            [NameInMap("enableCycleReservation")]
            [Validation(Required=false)]
            public bool? EnableCycleReservation { get; set; }

            [NameInMap("extensionConfig")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultExtensionConfig ExtensionConfig { get; set; }
            public class QueryMeetingRoomResponseBodyResultExtensionConfig : TeaModel {
                [NameInMap("advanceReservation")]
                [Validation(Required=false)]
                public QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation AdvanceReservation { get; set; }
                public class QueryMeetingRoomResponseBodyResultExtensionConfigAdvanceReservation : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>09:00</para>
                    /// </summary>
                    [NameInMap("advanceBookTimeFormat")]
                    [Validation(Required=false)]
                    public string AdvanceBookTimeFormat { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("advanceReservationTime")]
                    [Validation(Required=false)]
                    public int? AdvanceReservationTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>days</para>
                    /// </summary>
                    [NameInMap("advanceReservationTimeUnit")]
                    [Validation(Required=false)]
                    public string AdvanceReservationTimeUnit { get; set; }

                }

                [NameInMap("approvalSwitch")]
                [Validation(Required=false)]
                public bool? ApprovalSwitch { get; set; }

                [NameInMap("approvalType")]
                [Validation(Required=false)]
                public int? ApprovalType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("maxReservationTimeInterval")]
                [Validation(Required=false)]
                public int? MaxReservationTimeInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("minReservationTimeInterval")]
                [Validation(Required=false)]
                public int? MinReservationTimeInterval { get; set; }

                [NameInMap("openReservation")]
                [Validation(Required=false)]
                public bool? OpenReservation { get; set; }

                [NameInMap("reservationCloseDetail")]
                [Validation(Required=false)]
                public QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail ReservationCloseDetail { get; set; }
                public class QueryMeetingRoomResponseBodyResultExtensionConfigReservationCloseDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>因为装修临时关闭预定</para>
                    /// </summary>
                    [NameInMap("closeReason")]
                    [Validation(Required=false)]
                    public string CloseReason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nick</para>
                    /// </summary>
                    [NameInMap("contactNick")]
                    [Validation(Required=false)]
                    public string ContactNick { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2iPOLbpxxxxuwggiiqiPwiEiF</para>
                    /// </summary>
                    [NameInMap("contactUnionId")]
                    [Validation(Required=false)]
                    public string ContactUnionId { get; set; }

                    [NameInMap("sendNotify")]
                    [Validation(Required=false)]
                    public bool? SendNotify { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1740045030000</para>
                    /// </summary>
                    [NameInMap("taskEndTime")]
                    [Validation(Required=false)]
                    public long? TaskEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1740463800000</para>
                    /// </summary>
                    [NameInMap("taskStartTime")]
                    [Validation(Required=false)]
                    public long? TaskStartTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxIsvRoomId</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>此处添加对会议室的描述信息</para>
            /// </summary>
            [NameInMap("roomDescription")]
            [Validation(Required=false)]
            public string RoomDescription { get; set; }

            [NameInMap("roomGroup")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultRoomGroup RoomGroup { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomGroup : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>DtB8VDzXXXXXX41rgiE</para>
            /// </summary>
            [NameInMap("roomUnionId")]
            [Validation(Required=false)]
            public string RoomUnionId { get; set; }

        }

    }

}
