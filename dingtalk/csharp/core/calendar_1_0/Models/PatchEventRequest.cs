// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class PatchEventRequest : TeaModel {
        /// <summary>
        /// 日程标题
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// 日程id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 日程开始时间
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public PatchEventRequestStart Start { get; set; }
        public class PatchEventRequestStart : TeaModel {
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
        public PatchEventRequestEnd End { get; set; }
        public class PatchEventRequestEnd : TeaModel {
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
        public PatchEventRequestRecurrence Recurrence { get; set; }
        public class PatchEventRequestRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public PatchEventRequestRecurrencePattern Pattern { get; set; }
            public class PatchEventRequestRecurrencePattern : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("daysOfWeek")]
                [Validation(Required=false)]
                public string DaysOfWeek { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

            }
            [NameInMap("range")]
            [Validation(Required=false)]
            public PatchEventRequestRecurrenceRange Range { get; set; }
            public class PatchEventRequestRecurrenceRange : TeaModel {
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
        public List<PatchEventRequestAttendees> Attendees { get; set; }
        public class PatchEventRequestAttendees : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("location")]
        [Validation(Required=false)]
        public PatchEventRequestLocation Location { get; set; }
        public class PatchEventRequestLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
        };

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<PatchEventRequestReminders> Reminders { get; set; }
        public class PatchEventRequestReminders : TeaModel {
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("minutes")]
            [Validation(Required=false)]
            public int? Minutes { get; set; }

        }

    }

}
