// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class MemberModelMapValue : TeaModel {
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("userNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

        [NameInMap("joinTime")]
        [Validation(Required=false)]
        public long? JoinTime { get; set; }

        [NameInMap("leaveTime")]
        [Validation(Required=false)]
        public long? LeaveTime { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("attendStatus")]
        [Validation(Required=false)]
        public int? AttendStatus { get; set; }

        [NameInMap("host")]
        [Validation(Required=false)]
        public bool? Host { get; set; }

        [NameInMap("coHost")]
        [Validation(Required=false)]
        public bool? CoHost { get; set; }

        [NameInMap("outerOrgMember")]
        [Validation(Required=false)]
        public bool? OuterOrgMember { get; set; }

        [NameInMap("pstnJoin")]
        [Validation(Required=false)]
        public bool? PstnJoin { get; set; }

        [NameInMap("deviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

    }

}
