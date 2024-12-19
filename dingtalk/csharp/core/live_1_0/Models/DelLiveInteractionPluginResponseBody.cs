// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class DelLiveInteractionPluginResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DelLiveInteractionPluginResponseBodyResult Result { get; set; }
        public class DelLiveInteractionPluginResponseBodyResult : TeaModel {
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
