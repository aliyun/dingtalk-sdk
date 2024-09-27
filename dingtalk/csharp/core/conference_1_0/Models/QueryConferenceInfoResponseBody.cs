// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceInfoResponseBody : TeaModel {
        [NameInMap("confInfo")]
        [Validation(Required=false)]
        public QueryConferenceInfoResponseBodyConfInfo ConfInfo { get; set; }
        public class QueryConferenceInfoResponseBodyConfInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("activeNum")]
            [Validation(Required=false)]
            public int? ActiveNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("attendNum")]
            [Validation(Required=false)]
            public int? AttendNum { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("cloudRecordOwnerUnionId")]
            [Validation(Required=false)]
            public string CloudRecordOwnerUnionId { get; set; }

            [NameInMap("cloudRecordStatus")]
            [Validation(Required=false)]
            public int? CloudRecordStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("confDuration")]
            [Validation(Required=false)]
            public long? ConfDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6323d7568777190142ab9d10</para>
            /// </summary>
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>昵称</para>
            /// </summary>
            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("extensionAppSettings")]
            [Validation(Required=false)]
            public List<QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings> ExtensionAppSettings { get; set; }
            public class QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings : TeaModel {
                [NameInMap("appCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("autoOpenMode")]
                [Validation(Required=false)]
                public int? AutoOpenMode { get; set; }

                [NameInMap("extensionAppBizData")]
                [Validation(Required=false)]
                public string ExtensionAppBizData { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://meeting.dingtalk.com/app?roomCode=42726033559&token=1_7ac974ac-6e4f-47c3-b82b-bfb32fd94d2c">https://meeting.dingtalk.com/app?roomCode=42726033559&amp;token=1_7ac974ac-6e4f-47c3-b82b-bfb32fd94d2c</a></para>
            /// </summary>
            [NameInMap("externalLinkUrl")]
            [Validation(Required=false)]
            public string ExternalLinkUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("invitedNum")]
            [Validation(Required=false)]
            public int? InvitedNum { get; set; }

            [NameInMap("minutesOwnerUnionId")]
            [Validation(Required=false)]
            public string MinutesOwnerUnionId { get; set; }

            [NameInMap("minutesStatus")]
            [Validation(Required=false)]
            public int? MinutesStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42726033559</para>
            /// </summary>
            [NameInMap("roomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

            [NameInMap("scheduleConferenceId")]
            [Validation(Required=false)]
            public string ScheduleConferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1663293270000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
