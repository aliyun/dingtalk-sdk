// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListConnectorInformationResponseBody : TeaModel {
        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// pluginInfos
        /// </summary>
        [NameInMap("pluginInfos")]
        [Validation(Required=false)]
        public List<ListConnectorInformationResponseBodyPluginInfos> PluginInfos { get; set; }
        public class ListConnectorInformationResponseBodyPluginInfos : TeaModel {
            /// <summary>
            /// apps
            /// </summary>
            [NameInMap("apps")]
            [Validation(Required=false)]
            public List<ListConnectorInformationResponseBodyPluginInfosApps> Apps { get; set; }
            public class ListConnectorInformationResponseBodyPluginInfosApps : TeaModel {
                /// <summary>
                /// appName
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// iconUrl
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// pluginName
            /// </summary>
            [NameInMap("pluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// pluginPayType
            /// </summary>
            [NameInMap("pluginPayType")]
            [Validation(Required=false)]
            public int? PluginPayType { get; set; }

            /// <summary>
            /// pluginStatus
            /// </summary>
            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public int? PluginStatus { get; set; }

            /// <summary>
            /// pluginTotalAmount
            /// </summary>
            [NameInMap("pluginTotalAmount")]
            [Validation(Required=false)]
            public long? PluginTotalAmount { get; set; }

            /// <summary>
            /// pluginUsageAmount
            /// </summary>
            [NameInMap("pluginUsageAmount")]
            [Validation(Required=false)]
            public long? PluginUsageAmount { get; set; }

            /// <summary>
            /// pluginUuid
            /// </summary>
            [NameInMap("pluginUuid")]
            [Validation(Required=false)]
            public string PluginUuid { get; set; }

        }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
