// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ExecuteBatchTaskResponseBody : TeaModel {
        [NameInMap("failNumber")]
        [Validation(Required=false)]
        public int? FailNumber { get; set; }

        [NameInMap("successNumber")]
        [Validation(Required=false)]
        public int? SuccessNumber { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
