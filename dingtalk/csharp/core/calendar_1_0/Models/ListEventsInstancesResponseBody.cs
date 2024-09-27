// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsInstancesResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsInstancesResponseBodyEvents> Events { get; set; }
        public class ListEventsInstancesResponseBodyEvents : TeaModel {
            [NameInMap("attendees")]
            [Validation(Required=false)]
            public List<ListEventsInstancesResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsInstancesResponseBodyEventsAttendees : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>jack</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iiiP35sJaxxxxRKgiEiF</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("isOptional")]
                [Validation(Required=false)]
                public bool? IsOptional { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>accepted</para>
                /// </summary>
                [NameInMap("responseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01T10:15:30+08:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>something about this event</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("end")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsEnd End { get; set; }
            public class ListEventsInstancesResponseBodyEventsEnd : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01T11:15:30+08:00</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
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
            /// <b>Example:</b>
            /// <para>cnNTbW1YbxxxxdEgvdlQrQT09</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isAllDay")]
            [Validation(Required=false)]
            public bool? IsAllDay { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsLocation Location { get; set; }
            public class ListEventsInstancesResponseBodyEventsLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>room 1-2-3</para>
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
            public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsInstancesResponseBodyEventsOnlineMeetingInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5c4df21dxxxx-a6db402b9f3a&quot;</para>
                /// </summary>
                [NameInMap("conferenceId")]
                [Validation(Required=false)]
                public string ConferenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk://dingtalkclient/page/videoCoxxxxndar?confId=5c4df21dxxxx2b9f3a&amp;calendarId=92xxxx36</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("organizer")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsInstancesResponseBodyEventsOrganizer : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tony</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iiiP35sJaxxxxRKgiEiF</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>accepted</para>
                /// </summary>
                [NameInMap("responseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsInstancesResponseBodyEventsRecurrence : TeaModel {
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public ListEventsInstancesResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsInstancesResponseBodyEventsRecurrencePattern : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("dayOfMonth")]
                    [Validation(Required=false)]
                    public int? DayOfMonth { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sunday</para>
                    /// </summary>
                    [NameInMap("daysOfWeek")]
                    [Validation(Required=false)]
                    public string DaysOfWeek { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>first</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>daily</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("range")]
                [Validation(Required=false)]
                public ListEventsInstancesResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsInstancesResponseBodyEventsRecurrenceRange : TeaModel {
                    /// <summary>
                    /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-01-01T10:15:30+08:00</para>
                    /// </summary>
                    [NameInMap("endDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("numberOfOccurrences")]
                    [Validation(Required=false)]
                    public int? NumberOfOccurrences { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>noEnd</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("reminders")]
            [Validation(Required=false)]
            public List<ListEventsInstancesResponseBodyEventsReminders> Reminders { get; set; }
            public class ListEventsInstancesResponseBodyEventsReminders : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("minutes")]
                [Validation(Required=false)]
                public string Minutes { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cnNTbWxxxxaFJZdEgvdlQrQT09</para>
            /// </summary>
            [NameInMap("seriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsStart Start { get; set; }
            public class ListEventsInstancesResponseBodyEventsStart : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-01T10:15:30+08:00</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>confirmed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test event</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01T10:15:30+08:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
