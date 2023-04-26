// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateTeamRequest : TeaModel {
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateTeamRequestMembers> Members { get; set; }
        public class CreateTeamRequestMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("teamType")]
        [Validation(Required=false)]
        public int? TeamType { get; set; }

    }

}
