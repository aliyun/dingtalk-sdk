// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyUpdateMemberRequest : TeaModel {
        [NameInMap("isCopyDept")]
        [Validation(Required=false)]
        public bool? IsCopyDept { get; set; }

        [NameInMap("memberTitle")]
        [Validation(Required=false)]
        public string MemberTitle { get; set; }

        [NameInMap("memberWorkNumber")]
        [Validation(Required=false)]
        public string MemberWorkNumber { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("newDeptId")]
        [Validation(Required=false)]
        public long? NewDeptId { get; set; }

        [NameInMap("oldDeptId")]
        [Validation(Required=false)]
        public long? OldDeptId { get; set; }

        [NameInMap("roleIdList")]
        [Validation(Required=false)]
        public List<string> RoleIdList { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
