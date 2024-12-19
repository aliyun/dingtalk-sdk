// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceInfoByRoomCodeResponseBody : TeaModel {
        [NameInMap("conferenceList")]
        [Validation(Required=false)]
        public List<QueryConferenceInfoByRoomCodeResponseBodyConferenceList> ConferenceList { get; set; }
        public class QueryConferenceInfoByRoomCodeResponseBodyConferenceList : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

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

            [NameInMap("externalLinkUrl")]
            [Validation(Required=false)]
            public string ExternalLinkUrl { get; set; }

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

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
