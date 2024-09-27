// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class ProfessionBenefitConsumeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SF_INVOICE</para>
        /// </summary>
        [NameInMap("benefitCode")]
        [Validation(Required=false)]
        public string BenefitCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

    }

}
