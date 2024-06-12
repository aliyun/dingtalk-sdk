// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class VoiceCloneResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public VoiceCloneResponseBodyResult Result { get; set; }
        public class VoiceCloneResponseBodyResult : TeaModel {
            [NameInMap("mediaUrl")]
            [Validation(Required=false)]
            public string MediaUrl { get; set; }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
