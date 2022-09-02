// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class DingTalkSecurityCheckResponseBody : TeaModel {
        /// <summary>
        /// 返回参数
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DingTalkSecurityCheckResponseBodyResult Result { get; set; }
        public class DingTalkSecurityCheckResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否有风险
            /// </summary>
            [NameInMap("hasRisk")]
            [Validation(Required=false)]
            public bool? HasRisk { get; set; }

            /// <summary>
            /// 风险信息
            /// </summary>
            [NameInMap("riskInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskInfo { get; set; }

        }

    }

}
