// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationAuthorizationServiceConnectorInformationResponseBody : TeaModel {
        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// pluginInfos
        /// </summary>
        [NameInMap("plugInformation")]
        [Validation(Required=false)]
        public List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation> PlugInformation { get; set; }
        public class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation : TeaModel {
            /// <summary>
            /// pluginUuid
            /// </summary>
            [NameInMap("plugUuid")]
            [Validation(Required=false)]
            public string PlugUuid { get; set; }

            /// <summary>
            /// pluginTotalAmount
            /// </summary>
            [NameInMap("plugTotalAmount")]
            [Validation(Required=false)]
            public long? PlugTotalAmount { get; set; }

            /// <summary>
            /// pluginName
            /// </summary>
            [NameInMap("plugName")]
            [Validation(Required=false)]
            public string PlugName { get; set; }

            /// <summary>
            /// iconUrl
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// pluginPayType
            /// </summary>
            [NameInMap("plugPayType")]
            [Validation(Required=false)]
            public int? PlugPayType { get; set; }

            /// <summary>
            /// pluginUsageAmount
            /// </summary>
            [NameInMap("plugUsageAmount")]
            [Validation(Required=false)]
            public long? PlugUsageAmount { get; set; }

            /// <summary>
            /// pluginStatus
            /// </summary>
            [NameInMap("plugStatus")]
            [Validation(Required=false)]
            public int? PlugStatus { get; set; }

            /// <summary>
            /// apps
            /// </summary>
            [NameInMap("applications")]
            [Validation(Required=false)]
            public List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications> Applications { get; set; }
            public class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications : TeaModel {
                /// <summary>
                /// appName
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

        }

    }

}
