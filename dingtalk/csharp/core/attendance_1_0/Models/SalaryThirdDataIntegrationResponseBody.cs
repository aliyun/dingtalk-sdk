// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class SalaryThirdDataIntegrationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SalaryThirdDataIntegrationResponseBodyResult Result { get; set; }
        public class SalaryThirdDataIntegrationResponseBodyResult : TeaModel {
            [NameInMap("reason")]
            [Validation(Required=false)]
            public Dictionary<string, object> Reason { get; set; }

        }

    }

}
