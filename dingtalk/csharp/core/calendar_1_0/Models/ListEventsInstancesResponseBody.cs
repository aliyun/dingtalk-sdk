// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsInstancesResponseBody : TeaModel {
        /// <summary>
        /// 日程
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsInstancesResponseBodyEvents> Events { get; set; }
        public class ListEventsInstancesResponseBodyEvents : TeaModel {
            /// <summary>
            /// 日程参与人
            /// </summary>
            [NameInMap("attendees")]
            [Validation(Required=false)]
            public List<ListEventsInstancesResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsInstancesResponseBodyEventsAttendees : TeaModel {
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
            public ListEventsInstancesResponseBodyEventsEnd End { get; set; }
            public class ListEventsInstancesResponseBodyEventsEnd : TeaModel {
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

            [NameInMap("extendedProperties")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsInstancesResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("sharedProperties")]
                [Validation(Required=false)]
                public ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
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
            public ListEventsInstancesResponseBodyEventsLocation Location { get; set; }
            public class ListEventsInstancesResponseBodyEventsLocation : TeaModel {
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

            /// <summary>
            /// 线上会议
            /// </summary>
            [NameInMap("onlineMeetingInfo")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsInstancesResponseBodyEventsOnlineMeetingInfo : TeaModel {
                /// <summary>
                /// 会议ID
                /// </summary>
                [NameInMap("conferenceId")]
                [Validation(Required=false)]
                public string ConferenceId { get; set; }

                /// <summary>
                /// 线上会议类型，目前支持：  dingtalk：钉钉视频会议
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 会议url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 日程组织人
            /// </summary>
            [NameInMap("organizer")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsInstancesResponseBodyEventsOrganizer : TeaModel {
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
            public ListEventsInstancesResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsInstancesResponseBodyEventsRecurrence : TeaModel {
                /// <summary>
                /// 重复模式
                /// </summary>
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public ListEventsInstancesResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsInstancesResponseBodyEventsRecurrencePattern : TeaModel {
                    /// <summary>
                    /// 每月的第几天
                    /// </summary>
                    [NameInMap("dayOfMonth")]
                    [Validation(Required=false)]
                    public int? DayOfMonth { get; set; }

                    /// <summary>
                    /// 每周的第几天
                    /// </summary>
                    [NameInMap("daysOfWeek")]
                    [Validation(Required=false)]
                    public string DaysOfWeek { get; set; }

                    /// <summary>
                    /// 指定事件发生在daysOfsWeek中指定的允许天数的哪个实例上，从该月的第一个实例开始计算。取值为:first, second, third, fourth, last。默认是first。如果类型是relativMonthly或relativeYear，则可选并使用
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// 循环间隔
                    /// </summary>
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
                public ListEventsInstancesResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsInstancesResponseBodyEventsRecurrenceRange : TeaModel {
                    /// <summary>
                    /// 循环终止日期
                    /// </summary>
                    [NameInMap("endDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    /// <summary>
                    /// 循环出现次数
                    /// </summary>
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
            /// 日程提醒
            /// </summary>
            [NameInMap("reminders")]
            [Validation(Required=false)]
            public List<ListEventsInstancesResponseBodyEventsReminders> Reminders { get; set; }
            public class ListEventsInstancesResponseBodyEventsReminders : TeaModel {
                /// <summary>
                /// 提醒方式
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// 在日程开始前N分钟发出提醒
                /// </summary>
                [NameInMap("minutes")]
                [Validation(Required=false)]
                public string Minutes { get; set; }

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
            public ListEventsInstancesResponseBodyEventsStart Start { get; set; }
            public class ListEventsInstancesResponseBodyEventsStart : TeaModel {
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

    }

}
