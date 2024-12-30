// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvip_member_1_0.Models
{
    public class QueryVipMemberInfoResponseBody : TeaModel {
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("isVip")]
        [Validation(Required=false)]
        public bool? IsVip { get; set; }

    }

}
