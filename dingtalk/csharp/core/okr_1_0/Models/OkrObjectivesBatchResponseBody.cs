// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OkrObjectivesBatchResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<OpenObjectiveDTO> Content { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
