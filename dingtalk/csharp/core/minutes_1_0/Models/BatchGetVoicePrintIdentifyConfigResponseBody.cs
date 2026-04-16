// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class BatchGetVoicePrintIdentifyConfigResponseBody : TeaModel {
        [NameInMap("configItems")]
        [Validation(Required=false)]
        public List<BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems> ConfigItems { get; set; }
        public class BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems : TeaModel {
            [NameInMap("allowConfigVoicePrint")]
            [Validation(Required=false)]
            public bool? AllowConfigVoicePrint { get; set; }

            [NameInMap("enableVoicePrint")]
            [Validation(Required=false)]
            public bool? EnableVoicePrint { get; set; }

            [NameInMap("hasVoicePrintRecord")]
            [Validation(Required=false)]
            public bool? HasVoicePrintRecord { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
