// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsViewResponseBody : TeaModel {
        /// <summary>
        /// 日程
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsViewResponseBodyEvents> Events { get; set; }
        public class ListEventsViewResponseBodyEvents : TeaModel {
            /// <summary>
            /// 日程参与人
            /// </summary>
            [NameInMap("attendees")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsViewResponseBodyEventsAttendees : TeaModel {
                /// <summary>
                /// 用户名
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("isOptional")]
                [Validation(Required=false)]
                public bool? IsOptional { get; set; }

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

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 日程描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 日程结束时间
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsEnd End { get; set; }
            public class ListEventsViewResponseBodyEventsEnd : TeaModel {
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

            [NameInMap("extendedProperties")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsViewResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("sharedProperties")]
                [Validation(Required=false)]
                public ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
                    [NameInMap("sourceOpenCid")]
                    [Validation(Required=false)]
                    public string SourceOpenCid { get; set; }

                }

            }

            /// <summary>
            /// 日程事件id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 是否为全天日程
            /// </summary>
            [NameInMap("isAllDay")]
            [Validation(Required=false)]
            public bool? IsAllDay { get; set; }

            /// <summary>
            /// 日程地点
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsLocation Location { get; set; }
            public class ListEventsViewResponseBodyEventsLocation : TeaModel {
                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("meetingRooms")]
                [Validation(Required=false)]
                public List<string> MeetingRooms { get; set; }

            }

            [NameInMap("onlineMeetingInfo")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsViewResponseBodyEventsOnlineMeetingInfo : TeaModel {
                [NameInMap("conferenceId")]
                [Validation(Required=false)]
                public string ConferenceId { get; set; }

                [NameInMap("extraInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtraInfo { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 日程组织人
            /// </summary>
            [NameInMap("organizer")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsViewResponseBodyEventsOrganizer : TeaModel {
                /// <summary>
                /// 用户名
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

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

            /// <summary>
            /// 日程重复规则
            /// </summary>
            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsViewResponseBodyEventsRecurrence : TeaModel {
                /// <summary>
                /// 重复模式
                /// </summary>
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public ListEventsViewResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsViewResponseBodyEventsRecurrencePattern : TeaModel {
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

                    /// <summary>
                    /// 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// 重复范围
                /// </summary>
                [NameInMap("range")]
                [Validation(Required=false)]
                public ListEventsViewResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsViewResponseBodyEventsRecurrenceRange : TeaModel {
                    [NameInMap("endDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    [NameInMap("numberOfOccurrences")]
                    [Validation(Required=false)]
                    public int? NumberOfOccurrences { get; set; }

                    /// <summary>
                    /// 范围类型(endDate, noEnd, numbered)
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// 重复日程的主日程id，非重复日程为空
            /// </summary>
            [NameInMap("seriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            /// <summary>
            /// 日程开始时间
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsStart Start { get; set; }
            public class ListEventsViewResponseBodyEventsStart : TeaModel {
                /// <summary>
                /// 日期，格式：yyyyMMdd
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// 时间戳，按照ISO 8601格式
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// 时区
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// 日程状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 日程标题
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// 翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
