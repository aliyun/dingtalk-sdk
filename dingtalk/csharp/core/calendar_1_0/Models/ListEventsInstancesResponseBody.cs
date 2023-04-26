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
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("isOptional")]
                [Validation(Required=false)]
                public bool? IsOptional { get; set; }

                [NameInMap("responseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                [NameInMap("self")]
                [Validation(Required=false)]
                public bool? Self { get; set; }

            }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("end")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsEnd End { get; set; }
            public class ListEventsInstancesResponseBodyEventsEnd : TeaModel {
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

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isAllDay")]
            [Validation(Required=false)]
            public bool? IsAllDay { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsLocation Location { get; set; }
            public class ListEventsInstancesResponseBodyEventsLocation : TeaModel {
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
                [NameInMap("conferenceId")]
                [Validation(Required=false)]
                public string ConferenceId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("organizer")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsInstancesResponseBodyEventsOrganizer : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("responseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

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

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("range")]
                [Validation(Required=false)]
                public ListEventsInstancesResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsInstancesResponseBodyEventsRecurrenceRange : TeaModel {
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
            public List<ListEventsInstancesResponseBodyEventsReminders> Reminders { get; set; }
            public class ListEventsInstancesResponseBodyEventsReminders : TeaModel {
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("minutes")]
                [Validation(Required=false)]
                public string Minutes { get; set; }

            }

            [NameInMap("seriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public ListEventsInstancesResponseBodyEventsStart Start { get; set; }
            public class ListEventsInstancesResponseBodyEventsStart : TeaModel {
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

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
