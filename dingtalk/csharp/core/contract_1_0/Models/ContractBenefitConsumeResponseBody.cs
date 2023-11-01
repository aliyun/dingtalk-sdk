// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ContractBenefitConsumeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ContractBenefitConsumeResponseBodyResult Result { get; set; }
        public class ContractBenefitConsumeResponseBodyResult : TeaModel {
            [NameInMap("consumeResult")]
            [Validation(Required=false)]
            public bool? ConsumeResult { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
