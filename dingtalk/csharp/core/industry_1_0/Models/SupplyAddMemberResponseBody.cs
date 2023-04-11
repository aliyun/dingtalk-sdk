// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SupplyAddMemberResponseBodyResult Result { get; set; }
        public class SupplyAddMemberResponseBodyResult : TeaModel {
            /// <summary>
            /// 成员在钉钉组织的状态
            /// </summary>
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            /// <summary>
            /// isv内用户唯一id
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 已经进组织的用户唯一id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
