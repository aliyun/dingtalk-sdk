// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateEventByMeRequest : TeaModel {
        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<CreateEventByMeRequestAttendees> Attendees { get; set; }
        public class CreateEventByMeRequestAttendees : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isOptional")]
            [Validation(Required=false)]
            public bool? IsOptional { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public CreateEventByMeRequestEnd End { get; set; }
        public class CreateEventByMeRequestEnd : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        [NameInMap("isAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public CreateEventByMeRequestLocation Location { get; set; }
        public class CreateEventByMeRequestLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("onlineMeetingInfo")]
        [Validation(Required=false)]
        public CreateEventByMeRequestOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class CreateEventByMeRequestOnlineMeetingInfo : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public CreateEventByMeRequestRecurrence Recurrence { get; set; }
        public class CreateEventByMeRequestRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public CreateEventByMeRequestRecurrencePattern Pattern { get; set; }
            public class CreateEventByMeRequestRecurrencePattern : TeaModel {
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

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("range")]
            [Validation(Required=false)]
            public CreateEventByMeRequestRecurrenceRange Range { get; set; }
            public class CreateEventByMeRequestRecurrenceRange : TeaModel {
                /// <summary>
                /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("numberOfOccurrences")]
                [Validation(Required=false)]
                public int? NumberOfOccurrences { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<CreateEventByMeRequestReminders> Reminders { get; set; }
        public class CreateEventByMeRequestReminders : TeaModel {
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("minutes")]
            [Validation(Required=false)]
            public int? Minutes { get; set; }

        }

        [NameInMap("richTextDescription")]
        [Validation(Required=false)]
        public CreateEventByMeRequestRichTextDescription RichTextDescription { get; set; }
        public class CreateEventByMeRequestRichTextDescription : TeaModel {
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public CreateEventByMeRequestStart Start { get; set; }
        public class CreateEventByMeRequestStart : TeaModel {
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("uiConfigs")]
        [Validation(Required=false)]
        public List<CreateEventByMeRequestUiConfigs> UiConfigs { get; set; }
        public class CreateEventByMeRequestUiConfigs : TeaModel {
            [NameInMap("uiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            [NameInMap("uiStatus")]
            [Validation(Required=false)]
            public string UiStatus { get; set; }

        }

    }

}
