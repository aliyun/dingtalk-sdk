// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class UpdatePermissionForUsersRequest : TeaModel {
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdatePermissionForUsersRequestMembers> Members { get; set; }
        public class UpdatePermissionForUsersRequestMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("taskCreator")]
        [Validation(Required=false)]
        public long? TaskCreator { get; set; }

        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public long? OperatorUid { get; set; }

    }

}
