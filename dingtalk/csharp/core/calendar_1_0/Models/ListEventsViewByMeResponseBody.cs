// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsViewByMeResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<ListEventsViewByMeResponseBodyEvents> Events { get; set; }
        public class ListEventsViewByMeResponseBodyEvents : TeaModel {
            [NameInMap("attendees")]
            [Validation(Required=false)]
            public List<ListEventsViewByMeResponseBodyEventsAttendees> Attendees { get; set; }
            public class ListEventsViewByMeResponseBodyEventsAttendees : TeaModel {
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
            public List<ListEventsViewByMeResponseBodyEventsCategories> Categories { get; set; }
            public class ListEventsViewByMeResponseBodyEventsCategories : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("end")]
            [Validation(Required=false)]
            public ListEventsViewByMeResponseBodyEventsEnd End { get; set; }
            public class ListEventsViewByMeResponseBodyEventsEnd : TeaModel {
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
            public ListEventsViewByMeResponseBodyEventsExtendedProperties ExtendedProperties { get; set; }
            public class ListEventsViewByMeResponseBodyEventsExtendedProperties : TeaModel {
                [NameInMap("sharedProperties")]
                [Validation(Required=false)]
                public ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties SharedProperties { get; set; }
                public class ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties : TeaModel {
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
            public ListEventsViewByMeResponseBodyEventsLocation Location { get; set; }
            public class ListEventsViewByMeResponseBodyEventsLocation : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("meetingRooms")]
                [Validation(Required=false)]
                public List<string> MeetingRooms { get; set; }

            }

            [NameInMap("meetingRooms")]
            [Validation(Required=false)]
            public List<ListEventsViewByMeResponseBodyEventsMeetingRooms> MeetingRooms { get; set; }
            public class ListEventsViewByMeResponseBodyEventsMeetingRooms : TeaModel {
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
            public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo OnlineMeetingInfo { get; set; }
            public class ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo : TeaModel {
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
            public ListEventsViewByMeResponseBodyEventsOrganizer Organizer { get; set; }
            public class ListEventsViewByMeResponseBodyEventsOrganizer : TeaModel {
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
            public ListEventsViewByMeResponseBodyEventsOriginStart OriginStart { get; set; }
            public class ListEventsViewByMeResponseBodyEventsOriginStart : TeaModel {
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public ListEventsViewByMeResponseBodyEventsRecurrence Recurrence { get; set; }
            public class ListEventsViewByMeResponseBodyEventsRecurrence : TeaModel {
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public ListEventsViewByMeResponseBodyEventsRecurrencePattern Pattern { get; set; }
                public class ListEventsViewByMeResponseBodyEventsRecurrencePattern : TeaModel {
                    [NameInMap("dayOfMonth")]
                    [Validation(Required=false)]
                    public int? DayOfMonth { get; set; }

                    [NameInMap("daysOfWeek")]
                    [Validation(Required=false)]
                    public string DaysOfWeek { get; set; }

                    [NameInMap("firstDayOfWeek")]
                    [Validation(Required=false)]
                    public string FirstDayOfWeek { get; set; }

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
                public ListEventsViewByMeResponseBodyEventsRecurrenceRange Range { get; set; }
                public class ListEventsViewByMeResponseBodyEventsRecurrenceRange : TeaModel {
                    /// <summary>
                    /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                    /// </summary>
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

            [NameInMap("richTextDescription")]
            [Validation(Required=false)]
            public ListEventsViewByMeResponseBodyEventsRichTextDescription RichTextDescription { get; set; }
            public class ListEventsViewByMeResponseBodyEventsRichTextDescription : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("seriesMasterId")]
            [Validation(Required=false)]
            public string SeriesMasterId { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public ListEventsViewByMeResponseBodyEventsStart Start { get; set; }
            public class ListEventsViewByMeResponseBodyEventsStart : TeaModel {
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

            /// <summary>
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
