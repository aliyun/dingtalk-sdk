// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetLiveReplayUrlResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetLiveReplayUrlResponseBodyResult Result { get; set; }
        public class GetLiveReplayUrlResponseBodyResult : TeaModel {
            [NameInMap("replayUrl")]
            [Validation(Required=false)]
            public string ReplayUrl { get; set; }

        }

    }

}
