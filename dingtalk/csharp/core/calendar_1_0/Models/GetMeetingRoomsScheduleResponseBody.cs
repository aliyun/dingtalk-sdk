// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetMeetingRoomsScheduleResponseBody : TeaModel {
        /// <summary>
        /// 闲忙信息
        /// </summary>
        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetMeetingRoomsScheduleResponseBodyScheduleInformation : TeaModel {
            /// <summary>
            /// 异常描述
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// 用户userId
            /// </summary>
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("scheduleItems")]
            [Validation(Required=false)]
            public List<GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
                /// <summary>
                /// 结束时间，表示一个日期，或者一个带时区的时间戳
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
                    /// <summary>
                    /// 结束时间戳，按照ISO 8601格式
                    /// </summary>
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// 时间戳所属时区
                    /// </summary>
                    [NameInMap("timeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// 日程id。
                /// </summary>
                [NameInMap("eventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// 日程组织者。
                /// </summary>
                [NameInMap("organizer")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer Organizer { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer : TeaModel {
                    /// <summary>
                    /// 组织者名称。
                    /// </summary>
                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// 组织者unionId。
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                /// <summary>
                /// 开始时间，表示一个日期，或者一个带时区的时间戳
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
                    /// <summary>
                    /// 开始时间戳，按照ISO 8601格式
                    /// </summary>
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// 所属时区
                    /// </summary>
                    [NameInMap("timeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// 状态: - BUSY：繁忙, - TENTATIVE：暂定繁忙
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
