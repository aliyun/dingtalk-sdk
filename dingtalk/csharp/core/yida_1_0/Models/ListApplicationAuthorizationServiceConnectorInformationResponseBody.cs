// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationAuthorizationServiceConnectorInformationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("plugInformation")]
        [Validation(Required=false)]
        public List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation> PlugInformation { get; set; }
        public class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation : TeaModel {
            [NameInMap("applications")]
            [Validation(Required=false)]
            public List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications> Applications { get; set; }
            public class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications : TeaModel {
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("plugName")]
            [Validation(Required=false)]
            public string PlugName { get; set; }

            [NameInMap("plugPayType")]
            [Validation(Required=false)]
            public int? PlugPayType { get; set; }

            [NameInMap("plugStatus")]
            [Validation(Required=false)]
            public int? PlugStatus { get; set; }

            [NameInMap("plugTotalAmount")]
            [Validation(Required=false)]
            public long? PlugTotalAmount { get; set; }

            [NameInMap("plugUsageAmount")]
            [Validation(Required=false)]
            public long? PlugUsageAmount { get; set; }

            [NameInMap("plugUuid")]
            [Validation(Required=false)]
            public string PlugUuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
