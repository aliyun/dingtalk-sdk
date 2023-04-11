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
            /// <summary>
            /// 成员状态，已进组织或者待接收邀请
            /// </summary>
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            /// <summary>
            /// 成员是否激活
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// 成员名字
            /// </summary>
            [NameInMap("memberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// 成员在上下游中的工号
            /// </summary>
            [NameInMap("memberWorkNumber")]
            [Validation(Required=false)]
            public string MemberWorkNumber { get; set; }

        }

    }

}
