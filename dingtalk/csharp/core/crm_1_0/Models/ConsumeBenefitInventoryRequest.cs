// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ConsumeBenefitInventoryRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("benefitCode")]
        [Validation(Required=false)]
        public string BenefitCode { get; set; }

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
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

    }

}
