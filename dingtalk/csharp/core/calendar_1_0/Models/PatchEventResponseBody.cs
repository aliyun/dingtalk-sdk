// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class PatchEventResponseBody : TeaModel {
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
        public PatchEventResponseBodyStart Start { get; set; }
        public class PatchEventResponseBodyStart : TeaModel {
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
        public PatchEventResponseBodyEnd End { get; set; }
        public class PatchEventResponseBodyEnd : TeaModel {
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
        public PatchEventResponseBodyRecurrence Recurrence { get; set; }
        public class PatchEventResponseBodyRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public PatchEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class PatchEventResponseBodyRecurrencePattern : TeaModel {
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
            public PatchEventResponseBodyRecurrenceRange Range { get; set; }
            public class PatchEventResponseBodyRecurrenceRange : TeaModel {
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
        public List<PatchEventResponseBodyAttendees> Attendees { get; set; }
        public class PatchEventResponseBodyAttendees : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 回复状态
            /// </summary>
            [NameInMap("responseStatus")]
            [Validation(Required=false)]
            public string ResponseStatus { get; set; }

            /// <summary>
            /// 是否是当前登陆用户
            /// </summary>
            [NameInMap("self")]
            [Validation(Required=false)]
            public bool? Self { get; set; }

        }

        [NameInMap("organizer")]
        [Validation(Required=false)]
        public PatchEventResponseBodyOrganizer Organizer { get; set; }
        public class PatchEventResponseBodyOrganizer : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
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
        public PatchEventResponseBodyLocation Location { get; set; }
        public class PatchEventResponseBodyLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
        };

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<PatchEventResponseBodyReminders> Reminders { get; set; }
        public class PatchEventResponseBodyReminders : TeaModel {
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

    }

}
