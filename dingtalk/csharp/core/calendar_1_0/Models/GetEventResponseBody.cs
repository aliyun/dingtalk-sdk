// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetEventResponseBody : TeaModel {
        [NameInMap("attendees")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyAttendees> Attendees { get; set; }
        public class GetEventResponseBodyAttendees : TeaModel {
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

        [NameInMap("cardInstances")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyCardInstances> CardInstances { get; set; }
        public class GetEventResponseBodyCardInstances : TeaModel {
            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

            [NameInMap("scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

        }

        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyCategories> Categories { get; set; }
        public class GetEventResponseBodyCategories : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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

        }

        [NameInMap("extendedProperties")]
        [Validation(Required=false)]
        public GetEventResponseBodyExtendedProperties ExtendedProperties { get; set; }
        public class GetEventResponseBodyExtendedProperties : TeaModel {
            [NameInMap("sharedProperties")]
            [Validation(Required=false)]
            public GetEventResponseBodyExtendedPropertiesSharedProperties SharedProperties { get; set; }
            public class GetEventResponseBodyExtendedPropertiesSharedProperties : TeaModel {
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
        public GetEventResponseBodyLocation Location { get; set; }
        public class GetEventResponseBodyLocation : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("meetingRooms")]
            [Validation(Required=false)]
            public List<string> MeetingRooms { get; set; }

        }

        [NameInMap("meetingRooms")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyMeetingRooms> MeetingRooms { get; set; }
        public class GetEventResponseBodyMeetingRooms : TeaModel {
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
        public GetEventResponseBodyOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        public class GetEventResponseBodyOnlineMeetingInfo : TeaModel {
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
        public GetEventResponseBodyOrganizer Organizer { get; set; }
        public class GetEventResponseBodyOrganizer : TeaModel {
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
        public GetEventResponseBodyOriginStart OriginStart { get; set; }
        public class GetEventResponseBodyOriginStart : TeaModel {
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

        }

        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public GetEventResponseBodyRecurrence Recurrence { get; set; }
        public class GetEventResponseBodyRecurrence : TeaModel {
            [NameInMap("pattern")]
            [Validation(Required=false)]
            public GetEventResponseBodyRecurrencePattern Pattern { get; set; }
            public class GetEventResponseBodyRecurrencePattern : TeaModel {
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
            public GetEventResponseBodyRecurrenceRange Range { get; set; }
            public class GetEventResponseBodyRecurrenceRange : TeaModel {
                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
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

        [NameInMap("reminders")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyReminders> Reminders { get; set; }
        public class GetEventResponseBodyReminders : TeaModel {
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("minutes")]
            [Validation(Required=false)]
            public string Minutes { get; set; }

        }

        [NameInMap("richTextDescription")]
        [Validation(Required=false)]
        public GetEventResponseBodyRichTextDescription RichTextDescription { get; set; }
        public class GetEventResponseBodyRichTextDescription : TeaModel {
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

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

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>已取消、删除的日程是cancelled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("uiConfigs")]
        [Validation(Required=false)]
        public List<GetEventResponseBodyUiConfigs> UiConfigs { get; set; }
        public class GetEventResponseBodyUiConfigs : TeaModel {
            [NameInMap("uiName")]
            [Validation(Required=false)]
            public string UiName { get; set; }

            [NameInMap("uiStatus")]
            [Validation(Required=false)]
            public string UiStatus { get; set; }

        }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
