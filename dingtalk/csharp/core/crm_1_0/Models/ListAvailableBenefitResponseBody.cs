// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListAvailableBenefitResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAvailableBenefitResponseBodyResult> Result { get; set; }
        public class ListAvailableBenefitResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B_ACCOUNT_NUMBER</para>
            /// </summary>
            [NameInMap("benefitCode")]
            [Validation(Required=false)]
            public string BenefitCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1718696461851</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1718696461851</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tryout</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>试用版</para>
            /// </summary>
            [NameInMap("versionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

    }

}
