// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateEventResponseBody : TeaModel {
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 日程开始时间
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public CreateEventResponseBodyStart Start { get; set; }
        public class CreateEventResponseBodyStart : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }
        };

        [NameInMap("end")]
        [Validation(Required=false)]
        public CreateEventResponseBodyEnd End { get; set; }
        public class CreateEventResponseBodyEnd : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }
        };

        [NameInMap("isAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public CreateEventResponseBodyRecurrence Recurrence { get; set; }
        public class CreateEventResponseBodyRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public CreateEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class CreateEventResponseBodyRecurrencePattern : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("daysOfWeek")]
                [Validation(Required=false)]
                public string DaysOfWeek { get; set; }

                [NameInMap("firstDayOfWeek")]
                [Validation(Required=false)]
                public string FirstDayOfWeek { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

            }
            [NameInMap("range")]
            [Validation(Required=false)]
            public CreateEventResponseBodyRecurrenceRange Range { get; set; }
            public class CreateEventResponseBodyRecurrenceRange : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("numberOfOccurrences")]
                [Validation(Required=false)]
                public int? NumberOfOccurrences { get; set; }

            }
        };

        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<CreateEventResponseBodyAttendees> Attendees { get; set; }
        public class CreateEventResponseBodyAttendees : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 回复状态
            /// </summary>
            [NameInMap("responseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }

            [NameInMap("self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }

        }

        [NameInMap("organizer")]
        [Validation(Required=false)]
        public CreateEventResponseBodyOrganizer Organizer { get; set; }
        public class CreateEventResponseBodyOrganizer : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("responseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }
            [NameInMap("self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }
        };

        [NameInMap("location")]
        [Validation(Required=false)]
        public CreateEventResponseBodyLocation Location { get; set; }
        public class CreateEventResponseBodyLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
        };

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<CreateEventResponseBodyReminders> Reminders { get; set; }
        public class CreateEventResponseBodyReminders : TeaModel {
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("minutes")]
            [Validation(Required=false)]
            public string Minutes { get; set; }

        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public CreateEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class CreateEventResponseBodyOnlineMeetingInfo : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }
        };

    }

}
