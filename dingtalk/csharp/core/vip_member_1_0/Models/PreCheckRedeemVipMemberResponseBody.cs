// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvip_member_1_0.Models
{
    public class PreCheckRedeemVipMemberResponseBody : TeaModel {
        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
