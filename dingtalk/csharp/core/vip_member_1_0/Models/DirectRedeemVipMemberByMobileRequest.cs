// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvip_member_1_0.Models
{
    public class DirectRedeemVipMemberByMobileRequest : TeaModel {
        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("dingtalkId")]
        [Validation(Required=false)]
        public string DingtalkId { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
