// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchActionsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SearchActionsResponseBodyList> List { get; set; }
        public class SearchActionsResponseBodyList : TeaModel {
            [NameInMap("authorityUrl")]
            [Validation(Required=false)]
            public string AuthorityUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            [NameInMap("connectAssetUri")]
            [Validation(Required=false)]
            public string ConnectAssetUri { get; set; }

            [NameInMap("connectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("integrationType")]
            [Validation(Required=false)]
            public string IntegrationType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("providerCorpId")]
            [Validation(Required=false)]
            public string ProviderCorpId { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
