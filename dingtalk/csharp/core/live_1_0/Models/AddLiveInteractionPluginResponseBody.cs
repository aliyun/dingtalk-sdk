// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class AddLiveInteractionPluginResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddLiveInteractionPluginResponseBodyResult Result { get; set; }
        public class AddLiveInteractionPluginResponseBodyResult : TeaModel {
            [NameInMap("pluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

        }

    }

}
