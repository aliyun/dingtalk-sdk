// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class PushVerifyEventRequest : TeaModel {
        [NameInMap("callerDeviceId")]
        [Validation(Required=false)]
        public string CallerDeviceId { get; set; }

        [NameInMap("factorCodeList")]
        [Validation(Required=false)]
        public List<string> FactorCodeList { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
