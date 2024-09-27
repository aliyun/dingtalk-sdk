// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class PreventCheatingCheckRiskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PreventCheatingCheckRiskResponseBodyResult Result { get; set; }
        public class PreventCheatingCheckRiskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hasRisk")]
            [Validation(Required=false)]
            public bool? HasRisk { get; set; }

            [NameInMap("riskInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskInfo { get; set; }

        }

    }

}
