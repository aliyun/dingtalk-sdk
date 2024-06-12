// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class TextToImageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TextToImageResponseBodyResult Result { get; set; }
        public class TextToImageResponseBodyResult : TeaModel {
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
