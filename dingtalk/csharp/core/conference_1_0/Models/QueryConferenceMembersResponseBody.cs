// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceMembersResponseBody : TeaModel {
        [NameInMap("memberModels")]
        [Validation(Required=false)]
        public List<QueryConferenceMembersResponseBodyMemberModels> MemberModels { get; set; }
        public class QueryConferenceMembersResponseBodyMemberModels : TeaModel {
            [NameInMap("attendStatus")]
            [Validation(Required=false)]
            public int? AttendStatus { get; set; }

            [NameInMap("coHost")]
            [Validation(Required=false)]
            public bool? CoHost { get; set; }

            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("host")]
            [Validation(Required=false)]
            public bool? Host { get; set; }

            [NameInMap("joinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            [NameInMap("leaveTime")]
            [Validation(Required=false)]
            public long? LeaveTime { get; set; }

            [NameInMap("outerOrgMember")]
            [Validation(Required=false)]
            public bool? OuterOrgMember { get; set; }

            [NameInMap("pstnJoin")]
            [Validation(Required=false)]
            public bool? PstnJoin { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
