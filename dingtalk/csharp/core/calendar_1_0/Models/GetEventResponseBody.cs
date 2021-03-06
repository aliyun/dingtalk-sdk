// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetEventResponseBody : TeaModel {
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

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
        /// 日程状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 日程开始时间
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public GetEventResponseBodyStart Start { get; set; }
        public class GetEventResponseBodyStart : TeaModel {
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
        public GetEventResponseBodyEnd End { get; set; }
        public class GetEventResponseBodyEnd : TeaModel {
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

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public GetEventResponseBodyRecurrence Recurrence { get; set; }
        public class GetEventResponseBodyRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public GetEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class GetEventResponseBodyRecurrencePattern : TeaModel {
                /// <summary>
                /// 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
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
            public GetEventResponseBodyRecurrenceRange Range { get; set; }
            public class GetEventResponseBodyRecurrenceRange : TeaModel {
                /// <summary>
                /// 范围类型(endDate, noEnd, numbered)
                /// </summary>
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
        public List<GetEventResponseBodyAttendees> Attendees { get; set; }
        public class GetEventResponseBodyAttendees : TeaModel {
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
        public GetEventResponseBodyOrganizer Organizer { get; set; }
        public class GetEventResponseBodyOrganizer : TeaModel {
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
        public GetEventResponseBodyLocation Location { get; set; }
        public class GetEventResponseBodyLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
        };

        /// <summary>
        /// 重复日程的主日程id，非重复日程为空
        /// </summary>
        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

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
