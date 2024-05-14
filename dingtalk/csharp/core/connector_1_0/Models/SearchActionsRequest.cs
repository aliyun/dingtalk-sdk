// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchActionsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("connectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("connectorProviderCorpId")]
        [Validation(Required=false)]
        public string ConnectorProviderCorpId { get; set; }

        [NameInMap("integrationTypes")]
        [Validation(Required=false)]
        public List<string> IntegrationTypes { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
