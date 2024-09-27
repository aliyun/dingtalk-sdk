// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetAppResourceUseInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>api_count</para>
        /// </summary>
        [NameInMap("benefitCode")]
        [Validation(Required=false)]
        public string BenefitCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202302</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202301</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
