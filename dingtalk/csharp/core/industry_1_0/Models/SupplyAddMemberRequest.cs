// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddMemberRequest : TeaModel {
        [NameInMap("isPartnerManager")]
        [Validation(Required=false)]
        public bool? IsPartnerManager { get; set; }

        [NameInMap("memberMobile")]
        [Validation(Required=false)]
        public string MemberMobile { get; set; }

        [NameInMap("memberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        [NameInMap("memberWorkNumber")]
        [Validation(Required=false)]
        public string MemberWorkNumber { get; set; }

        [NameInMap("supplyDeptId")]
        [Validation(Required=false)]
        public long? SupplyDeptId { get; set; }

    }

}
