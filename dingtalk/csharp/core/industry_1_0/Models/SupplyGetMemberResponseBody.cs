// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyGetMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SupplyGetMemberResponseBodyResult Result { get; set; }
        public class SupplyGetMemberResponseBodyResult : TeaModel {
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            [NameInMap("memberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            [NameInMap("memberWorkNumber")]
            [Validation(Required=false)]
            public string MemberWorkNumber { get; set; }

        }

    }

}
