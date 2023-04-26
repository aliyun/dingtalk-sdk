// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationAuthorizationServiceApplicationInformationResponseBody : TeaModel {
        [NameInMap("applicationInformation")]
        [Validation(Required=false)]
        public List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation> ApplicationInformation { get; set; }
        public class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation : TeaModel {
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("attachmentUsageAmount")]
            [Validation(Required=false)]
            public long? AttachmentUsageAmount { get; set; }

            [NameInMap("instanceUsageAmount")]
            [Validation(Required=false)]
            public long? InstanceUsageAmount { get; set; }

            [NameInMap("usagePlugins")]
            [Validation(Required=false)]
            public List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins> UsagePlugins { get; set; }
            public class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins : TeaModel {
                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                [NameInMap("pluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

            }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
