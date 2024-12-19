// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveInteractionPluginResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveInteractionPluginResponseBodyResult Result { get; set; }
        public class QueryLiveInteractionPluginResponseBodyResult : TeaModel {
            [NameInMap("livePluginList")]
            [Validation(Required=false)]
            public List<QueryLiveInteractionPluginResponseBodyResultLivePluginList> LivePluginList { get; set; }
            public class QueryLiveInteractionPluginResponseBodyResultLivePluginList : TeaModel {
                [NameInMap("anchorJumpUrl")]
                [Validation(Required=false)]
                public string AnchorJumpUrl { get; set; }

                [NameInMap("pluginIconUrl")]
                [Validation(Required=false)]
                public string PluginIconUrl { get; set; }

                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("pluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                [NameInMap("pluginNameEn")]
                [Validation(Required=false)]
                public string PluginNameEn { get; set; }

                [NameInMap("viewerJumpUrl")]
                [Validation(Required=false)]
                public string ViewerJumpUrl { get; set; }

            }

        }

    }

}
