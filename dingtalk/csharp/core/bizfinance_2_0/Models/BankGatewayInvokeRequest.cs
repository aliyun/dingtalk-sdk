// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BankGatewayInvokeRequest : TeaModel {
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("inputData")]
        [Validation(Required=false)]
        public string InputData { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
