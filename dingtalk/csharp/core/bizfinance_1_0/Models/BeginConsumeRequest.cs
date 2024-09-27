// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BeginConsumeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B_SF2_INVOICE_OCR</para>
        /// </summary>
        [NameInMap("benefitCode")]
        [Validation(Required=false)]
        public string BenefitCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
