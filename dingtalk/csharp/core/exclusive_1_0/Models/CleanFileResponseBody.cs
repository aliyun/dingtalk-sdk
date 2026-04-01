// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CleanFileResponseBody : TeaModel {
        [NameInMap("failureIds")]
        [Validation(Required=false)]
        public List<long?> FailureIds { get; set; }

        [NameInMap("successIds")]
        [Validation(Required=false)]
        public List<long?> SuccessIds { get; set; }

    }

}
