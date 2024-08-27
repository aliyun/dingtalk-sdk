// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumSaveIntegratedProcessResponseBodyResult Result { get; set; }
        public class PremiumSaveIntegratedProcessResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
