// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateEventRequest : TeaModel {
        /// <summary>
        /// 日程标题
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// 日程描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 日程开始时间
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public CreateEventRequestStart Start { get; set; }
        public class CreateEventRequestStart : TeaModel {
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

        /// <summary>
        /// 日程结束时间
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public CreateEventRequestEnd End { get; set; }
        public class CreateEventRequestEnd : TeaModel {
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

        /// <summary>
        /// 是否为全天日程
        /// </summary>
        [NameInMap("isAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// 日程循环规则
        /// </summary>
        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public CreateEventRequestRecurrence Recurrence { get; set; }
        public class CreateEventRequestRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public CreateEventRequestRecurrencePattern Pattern { get; set; }
            public class CreateEventRequestRecurrencePattern : TeaModel {
                /// <summary>
                /// 循环规则类型：  daily：每interval天 weekly：每interval周的第daysOfWeek天 absoluteMonthly：每interval月的第dayOfMonth天 relativeMonthly：每interval月的第index周的第daysOfWeek天 absoluteYearly：每interval年
                /// 
                /// </summary>
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
            public CreateEventRequestRecurrenceRange Range { get; set; }
            public class CreateEventRequestRecurrenceRange : TeaModel {
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
        public List<CreateEventRequestAttendees> Attendees { get; set; }
        public class CreateEventRequestAttendees : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("location")]
        [Validation(Required=false)]
        public CreateEventRequestLocation Location { get; set; }
        public class CreateEventRequestLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
        };

    }

}
