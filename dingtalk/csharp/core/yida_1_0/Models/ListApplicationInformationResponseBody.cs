// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationInformationResponseBody : TeaModel {
        /// <summary>
        /// applicationInformation
        /// </summary>
        [NameInMap("applicationInformation")]
        [Validation(Required=false)]
        public List<ListApplicationInformationResponseBodyApplicationInformation> ApplicationInformation { get; set; }
        public class ListApplicationInformationResponseBodyApplicationInformation : TeaModel {
            /// <summary>
            /// appName
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// appType
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// attachmentUsageAmount
            /// </summary>
            [NameInMap("attachmentUsageAmount")]
            [Validation(Required=false)]
            public long? AttachmentUsageAmount { get; set; }

            /// <summary>
            /// instanceUsageAmount
            /// </summary>
            [NameInMap("instanceUsageAmount")]
            [Validation(Required=false)]
            public long? InstanceUsageAmount { get; set; }

            /// <summary>
            /// usagePlugins
            /// </summary>
            [NameInMap("usagePlugins")]
            [Validation(Required=false)]
            public List<ListApplicationInformationResponseBodyApplicationInformationUsagePlugins> UsagePlugins { get; set; }
            public class ListApplicationInformationResponseBodyApplicationInformationUsagePlugins : TeaModel {
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

            }

        }

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
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
