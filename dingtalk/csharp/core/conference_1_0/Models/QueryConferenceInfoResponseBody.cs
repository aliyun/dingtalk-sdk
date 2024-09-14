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
            [NameInMap("activeNum")]
            [Validation(Required=false)]
            public int? ActiveNum { get; set; }

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

            [NameInMap("confDuration")]
            [Validation(Required=false)]
            public long? ConfDuration { get; set; }

            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

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

            [NameInMap("externalLinkUrl")]
            [Validation(Required=false)]
            public string ExternalLinkUrl { get; set; }

            [NameInMap("invitedNum")]
            [Validation(Required=false)]
            public int? InvitedNum { get; set; }

            [NameInMap("minutesOwnerUnionId")]
            [Validation(Required=false)]
            public string MinutesOwnerUnionId { get; set; }

            [NameInMap("minutesStatus")]
            [Validation(Required=false)]
            public int? MinutesStatus { get; set; }

            [NameInMap("roomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

            [NameInMap("scheduleConferenceId")]
            [Validation(Required=false)]
            public string ScheduleConferenceId { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
