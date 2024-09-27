// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class DingTalkSecurityCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DingTalkSecurityCheckResponseBodyResult Result { get; set; }
        public class DingTalkSecurityCheckResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasRisk")]
            [Validation(Required=false)]
            public bool? HasRisk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;riskTypeMinor&quot;:&quot;bbbb&quot;&quot;riskTypeMajor&quot;:&quot;aaaa&quot;&quot;riskTypeMsg&quot;:&quot;ccc&quot;}</para>
            /// </summary>
            [NameInMap("riskInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskInfo { get; set; }

        }

    }

}
