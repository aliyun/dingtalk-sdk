// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListConnectorInformationResponseBody : TeaModel {
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("pluginInfos")]
        [Validation(Required=false)]
        public List<ListConnectorInformationResponseBodyPluginInfos> PluginInfos { get; set; }
        public class ListConnectorInformationResponseBodyPluginInfos : TeaModel {
            [NameInMap("apps")]
            [Validation(Required=false)]
            public List<ListConnectorInformationResponseBodyPluginInfosApps> Apps { get; set; }
            public class ListConnectorInformationResponseBodyPluginInfosApps : TeaModel {
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("pluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            [NameInMap("pluginPayType")]
            [Validation(Required=false)]
            public int? PluginPayType { get; set; }

            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public int? PluginStatus { get; set; }

            [NameInMap("pluginTotalAmount")]
            [Validation(Required=false)]
            public long? PluginTotalAmount { get; set; }

            [NameInMap("pluginUsageAmount")]
            [Validation(Required=false)]
            public long? PluginUsageAmount { get; set; }

            [NameInMap("pluginUuid")]
            [Validation(Required=false)]
            public string PluginUuid { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
