// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ContractBenefitConsumeRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("benefitPoint")]
        [Validation(Required=false)]
        public string BenefitPoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("consumeQuota")]
        [Validation(Required=false)]
        public long? ConsumeQuota { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isvCorpId")]
        [Validation(Required=false)]
        public string IsvCorpId { get; set; }

        [NameInMap("optUnionId")]
        [Validation(Required=false)]
        public string OptUnionId { get; set; }

    }

}
