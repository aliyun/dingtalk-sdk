// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsResponseBodyEvents> Events { get; set; }
        public class ListEventsResponseBodyEvents : TeaModel {
            [NameInMap("attendees")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsResponseBodyEventsAttendees : TeaModel {
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
            public List<ListEventsResponseBodyEventsCategories> Categories { get; set; }
            public class ListEventsResponseBodyEventsCategories : TeaModel {
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
            public ListEventsResponseBodyEventsEnd End { get; set; }
            public class ListEventsResponseBodyEventsEnd : TeaModel {
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
            public ListEventsResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("sharedProperties")]
                [Validation(Required=false)]
                public ListEventsResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
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
            public ListEventsResponseBodyEventsLocation Location { get; set; }
            public class ListEventsResponseBodyEventsLocation : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("meetingRooms")]
                [Validation(Required=false)]
                public List<string> MeetingRooms { get; set; }

            }

            [NameInMap("meetingRooms")]
            [Validation(Required=false)]
            public List<ListEventsResponseBodyEventsMeetingRooms> MeetingRooms { get; set; }
            public class ListEventsResponseBodyEventsMeetingRooms : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("responseStatus")]
                [Validation(Required=false)]
                public string ResponseStatus { get; set; }

                [NameInMap("roomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

            }

            [NameInMap("onlineMeetingInfo")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsResponseBodyEventsOnlineMeetingInfo : TeaModel {
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
            public ListEventsResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsResponseBodyEventsOrganizer : TeaModel {
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
            public ListEventsResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsResponseBodyEventsOriginStart : TeaModel {
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsResponseBodyEventsRecurrence : TeaModel {
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public ListEventsResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsResponseBodyEventsRecurrencePattern : TeaModel {
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
                public ListEventsResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsResponseBodyEventsRecurrenceRange : TeaModel {
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
            public List<ListEventsResponseBodyEventsReminders> Reminders { get; set; }
            public class ListEventsResponseBodyEventsReminders : TeaModel {
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("minutes")]
                [Validation(Required=false)]
                public string Minutes { get; set; }

            }

            [NameInMap("richTextDescription")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsRichTextDescription RichTextDescription { get; set; }
            public class ListEventsResponseBodyEventsRichTextDescription : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("seriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public ListEventsResponseBodyEventsStart Start { get; set; }
            public class ListEventsResponseBodyEventsStart : TeaModel {
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

        [NameInMap("syncToken")]
        [Validation(Required=false)]
        public string SyncToken { get; set; }

    }

}
