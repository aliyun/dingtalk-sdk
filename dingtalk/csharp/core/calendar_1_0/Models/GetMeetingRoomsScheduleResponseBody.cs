// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetMeetingRoomsScheduleResponseBody : TeaModel {
        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetMeetingRoomsScheduleResponseBodyScheduleInformation : TeaModel {
            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("scheduleItems")]
            [Validation(Required=false)]
            public List<GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    [NameInMap("timeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                [NameInMap("eventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("organizer")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer Organizer { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                [NameInMap("start")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    [NameInMap("timeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
