// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateChecklistRuleShrinkRequest : TeaModel {
        [NameInMap("contract_type")]
        [Validation(Required=false)]
        public string ContractType { get; set; }

        [NameInMap("corp_id")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public string ItemsShrink { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("risk_level")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        [NameInMap("standpoint")]
        [Validation(Required=false)]
        public string Standpoint { get; set; }

    }

}
