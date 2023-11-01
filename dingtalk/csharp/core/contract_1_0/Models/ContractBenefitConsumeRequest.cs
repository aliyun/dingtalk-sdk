// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ContractBenefitConsumeRequest : TeaModel {
        [NameInMap("benefitPoint")]
        [Validation(Required=false)]
        public string BenefitPoint { get; set; }

        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        [NameInMap("consumeQuota")]
        [Validation(Required=false)]
        public long? ConsumeQuota { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtParams { get; set; }

        [NameInMap("isvCorpId")]
        [Validation(Required=false)]
        public string IsvCorpId { get; set; }

        [NameInMap("optUnionId")]
        [Validation(Required=false)]
        public string OptUnionId { get; set; }

    }

}
