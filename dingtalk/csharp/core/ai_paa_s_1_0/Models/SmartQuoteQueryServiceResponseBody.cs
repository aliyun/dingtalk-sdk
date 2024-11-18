// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class SmartQuoteQueryServiceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SmartQuoteQueryServiceResponseBodyResult Result { get; set; }
        public class SmartQuoteQueryServiceResponseBodyResult : TeaModel {
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
