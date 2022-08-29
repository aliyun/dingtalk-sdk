// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BatchCreateCustomerResponseBody : TeaModel {
        [NameInMap("errorResult")]
        [Validation(Required=false)]
        public List<BatchCreateCustomerResponseBodyErrorResult> ErrorResult { get; set; }
        public class BatchCreateCustomerResponseBodyErrorResult : TeaModel {
            [NameInMap("errorKey")]
            [Validation(Required=false)]
            public string ErrorKey { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
