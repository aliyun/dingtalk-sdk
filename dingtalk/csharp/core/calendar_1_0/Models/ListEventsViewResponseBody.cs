// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsViewResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsViewResponseBodyEvents> Events { get; set; }
        public class ListEventsViewResponseBodyEvents : TeaModel {
            [NameInMap("attendees")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsViewResponseBodyEventsAttendees : TeaModel {
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

            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<ListEventsViewResponseBodyEventsCategories> Categories { get; set; }
            public class ListEventsViewResponseBodyEventsCategories : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
                    [NameInMap("belongCorpId")]
                    [Validation(Required=false)]
                    public string BelongCorpId { get; set; }

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
            public ListEventsViewResponseBodyEventsLocation Location { get; set; }
            public class ListEventsViewResponseBodyEventsLocation : TeaModel {
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

            [NameInMap("organizer")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsViewResponseBodyEventsOrganizer : TeaModel {
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

            [NameInMap("originStart")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsViewResponseBodyEventsOriginStart : TeaModel {
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsViewResponseBodyEventsRecurrence : TeaModel {
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

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

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

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("seriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public ListEventsViewResponseBodyEventsStart Start { get; set; }
            public class ListEventsViewResponseBodyEventsStart : TeaModel {
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

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
