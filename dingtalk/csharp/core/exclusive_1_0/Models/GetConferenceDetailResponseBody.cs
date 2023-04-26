// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetConferenceDetailResponseBody : TeaModel {
        [NameInMap("attendeeNum")]
        [Validation(Required=false)]
        public long? AttendeeNum { get; set; }

        [NameInMap("attendeePercentage")]
        [Validation(Required=false)]
        public string AttendeePercentage { get; set; }

        [NameInMap("callerId")]
        [Validation(Required=false)]
        public string CallerId { get; set; }

        [NameInMap("callerName")]
        [Validation(Required=false)]
        public string CallerName { get; set; }

        [NameInMap("confStartTime")]
        [Validation(Required=false)]
        public float? ConfStartTime { get; set; }

        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        [NameInMap("memberList")]
        [Validation(Required=false)]
        public List<GetConferenceDetailResponseBodyMemberList> MemberList { get; set; }
        public class GetConferenceDetailResponseBodyMemberList : TeaModel {
            [NameInMap("attendDuration")]
            [Validation(Required=false)]
            public float? AttendDuration { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("totalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
